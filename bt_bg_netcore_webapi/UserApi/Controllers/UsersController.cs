using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserApi.Data;
using UserApi.DTOs;
using UserApi.Models;

namespace UserApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/users
        [HttpGet]
        public async Task<IActionResult> GetUsers(
            int pageIndex = 1,
            int pageSize = 10,
            string? sortBy = "id",
            string? sortDirection = "asc",
            string? keyword = null)
        {
            if (pageIndex <= 0)
            {
                return BadRequest(new ApiResponse<object>
                {
                    StatusCode = 400,
                    Message = "pageIndex phải lớn hơn 0",
                    Content = null
                });
            }

            if (pageSize <= 0 || pageSize > 100)
            {
                return BadRequest(new ApiResponse<object>
                {
                    StatusCode = 400,
                    Message = "pageSize phải lớn hơn 0 và nhỏ hơn hoặc bằng 100",
                    Content = null
                });
            }

            var query = _context.Users
                .AsNoTracking()
                .Where(u => u.Deleted == false);

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(u => u.Name.Contains(keyword));
            }

            bool isDescending = sortDirection?.ToLower() == "desc";
            query = sortBy?.ToLower() switch
            {
                "name" => isDescending
                    ? query.OrderByDescending(u => u.Name)
                    : query.OrderBy(u => u.Name),
                "createdat" => isDescending
                    ? query.OrderByDescending(u => u.CreatedAt)
                    : query.OrderBy(u => u.CreatedAt),
                _ => isDescending
                    ? query.OrderByDescending(u => u.Id)
                    : query.OrderBy(u => u.Id)
            };

            int totalItems = await query.CountAsync();
            var users = await query
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var result = new
            {
                totalItems,
                pageIndex,
                pageSize,
                totalPages = (int)Math.Ceiling(totalItems / (double)pageSize),
                items = users
            };

            return Ok(new ApiResponse<object>
            {
                StatusCode = 200,
                Message = "Lấy danh sách User thành công",
                Content = result
            });
        }

        // GET: api/users/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Id == id && u.Deleted == false);

            if (user == null)
            {
                return NotFound(new ApiResponse<object>
                {
                    StatusCode = 404,
                    Message = "Không tìm thấy User",
                    Content = null
                });
            }

            return Ok(new ApiResponse<User>
            {
                StatusCode = 200,
                Message = "Lấy chi tiết User thành công",
                Content = user
            });
        }

        // POST: api/users
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ApiResponse<object>
                {
                    StatusCode = 400,
                    Message = "Dữ liệu đầu vào không hợp lệ",
                    Content = ModelState
                });
            }

            var user = new User
            {
                Name = request.Name,
                Email = request.Email,
                Description = request.Description,
                Age = request.Age,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Deleted = false
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return Ok(new ApiResponse<User>
            {
                StatusCode = 200,
                Message = "Thêm User thành công",
                Content = user
            });
        }

        // PUT: api/users/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] UpdateUserRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ApiResponse<object>
                {
                    StatusCode = 400,
                    Message = "Dữ liệu đầu vào không hợp lệ",
                    Content = ModelState
                });
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Id == id && u.Deleted == false);

            if (user == null)
            {
                return NotFound(new ApiResponse<object>
                {
                    StatusCode = 404,
                    Message = "Không tìm thấy User cần cập nhật",
                    Content = null
                });
            }

            user.Name = request.Name;
            user.Email = request.Email;
            user.Description = request.Description;
            user.Age = request.Age;
            user.UpdatedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return Ok(new ApiResponse<User>
            {
                StatusCode = 200,
                Message = "Cập nhật User thành công",
                Content = user
            });
        }

        // DELETE: api/users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Id == id && u.Deleted == false);

            if (user == null)
            {
                return NotFound(new ApiResponse<object>
                {
                    StatusCode = 404,
                    Message = "Không tìm thấy User cần xóa",
                    Content = null
                });
            }

            // Xóa mềm - không dùng _context.Users.Remove(user)
            user.Deleted = true;
            user.UpdatedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return Ok(new ApiResponse<object>
            {
                StatusCode = 200,
                Message = "Xóa mềm User thành công",
                Content = new
                {
                    user.Id,
                    user.Name,
                    user.Email,
                    user.Deleted,
                    user.UpdatedAt
                }
            });
        }
    }
}
