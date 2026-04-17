const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
const phoneRegex = /^\d{10,12}$/;

function setError(inputId, message) {
  const input = document.getElementById(inputId);
  const errorEl = document.querySelector(`[data-error-for="${inputId}"]`);

  if (!input || !errorEl) {
    return;
  }

  errorEl.textContent = message;
  if (message) {
    input.classList.add("invalid");
  } else {
    input.classList.remove("invalid");
  }
}

function setGenericError(errorKey, message) {
  const errorEl = document.querySelector(`[data-error-for="${errorKey}"]`);
  if (errorEl) {
    errorEl.textContent = message;
  }
}

function clearSuccess(formId) {
  const successEl = document.querySelector(`[data-success-for="${formId}"]`);
  if (successEl) {
    successEl.textContent = "";
  }
}

function showSuccess(formId, message) {
  const successEl = document.querySelector(`[data-success-for="${formId}"]`);
  if (successEl) {
    successEl.textContent = message;
  }
}

function validateContactForm() {
  let isValid = true;

  const fullName = document.getElementById("contactName").value.trim();
  const email = document.getElementById("contactEmail").value.trim();
  const phone = document.getElementById("contactPhone").value.trim();
  const address = document.getElementById("contactAddress").value.trim();
  const message = document.getElementById("contactMessage").value.trim();
  const service = document.getElementById("contactService").value;
  const termsChecked = document.getElementById("contactTerms").checked;

  if (!fullName) {
    setError("contactName", "Full name is required.");
    isValid = false;
  } else if (fullName.length < 3) {
    setError("contactName", "Full name must be at least 3 characters.");
    isValid = false;
  } else {
    setError("contactName", "");
  }

  if (!email) {
    setError("contactEmail", "Email is required.");
    isValid = false;
  } else if (!emailRegex.test(email)) {
    setError("contactEmail", "Please enter a valid email address.");
    isValid = false;
  } else {
    setError("contactEmail", "");
  }

  if (!phone) {
    setError("contactPhone", "Phone number is required.");
    isValid = false;
  } else if (!phoneRegex.test(phone)) {
    setError("contactPhone", "Phone number must contain 10 to 12 digits.");
    isValid = false;
  } else {
    setError("contactPhone", "");
  }

  if (address && address.length < 5) {
    setError(
      "contactAddress",
      "Address must be at least 5 characters when provided.",
    );
    isValid = false;
  } else {
    setError("contactAddress", "");
  }

  if (!message) {
    setError("contactMessage", "Message is required.");
    isValid = false;
  } else if (message.length < 10) {
    setError("contactMessage", "Message must be at least 10 characters.");
    isValid = false;
  } else {
    setError("contactMessage", "");
  }

  if (!service) {
    setError("contactService", "Please select a service.");
    isValid = false;
  } else {
    setError("contactService", "");
  }

  if (!termsChecked) {
    setGenericError("contactTerms", "You must agree to terms and conditions.");
    isValid = false;
  } else {
    setGenericError("contactTerms", "");
  }

  return isValid;
}

function validateCourseForm() {
  let isValid = true;

  const fullName = document.getElementById("courseName").value.trim();
  const email = document.getElementById("courseEmail").value.trim();
  const phone = document.getElementById("coursePhone").value.trim();
  const course = document.getElementById("courseSelect").value;
  const studyModes = document.querySelectorAll('input[name="studyMode"]');
  const date = document.getElementById("courseDate").value;
  const termsChecked = document.getElementById("courseTerms").checked;

  if (!fullName) {
    setError("courseName", "Full name is required.");
    isValid = false;
  } else if (fullName.length < 3) {
    setError("courseName", "Full name must be at least 3 characters.");
    isValid = false;
  } else {
    setError("courseName", "");
  }

  if (!email) {
    setError("courseEmail", "Email is required.");
    isValid = false;
  } else if (!emailRegex.test(email)) {
    setError("courseEmail", "Please enter a valid email address.");
    isValid = false;
  } else {
    setError("courseEmail", "");
  }

  if (!phone) {
    setError("coursePhone", "Phone number is required.");
    isValid = false;
  } else if (!phoneRegex.test(phone)) {
    setError("coursePhone", "Phone number must contain 10 to 12 digits.");
    isValid = false;
  } else {
    setError("coursePhone", "");
  }

  if (!course) {
    setError("courseSelect", "Please select a course.");
    isValid = false;
  } else {
    setError("courseSelect", "");
  }

  const selectedMode = Array.from(studyModes).find((item) => item.checked);
  const radioGroup = document.querySelector(".radio-group");

  if (!selectedMode) {
    setGenericError("studyMode", "Please choose one study mode.");
    radioGroup.classList.add("invalid");
    isValid = false;
  } else {
    setGenericError("studyMode", "");
    radioGroup.classList.remove("invalid");
  }

  if (!date) {
    setError("courseDate", "Please choose a preferred start date.");
    isValid = false;
  } else {
    setError("courseDate", "");
  }

  if (!termsChecked) {
    setGenericError("courseTerms", "You must agree to terms and conditions.");
    isValid = false;
  } else {
    setGenericError("courseTerms", "");
  }

  return isValid;
}

document.getElementById("contactForm").addEventListener("submit", (event) => {
  event.preventDefault();
  clearSuccess("contactForm");

  if (validateContactForm()) {
    event.target.reset();
    showSuccess("contactForm", "Contact form submitted successfully.");
  }
});

document.getElementById("courseForm").addEventListener("submit", (event) => {
  event.preventDefault();
  clearSuccess("courseForm");

  if (validateCourseForm()) {
    event.target.reset();
    const radioGroup = document.querySelector(".radio-group");
    radioGroup.classList.remove("invalid");
    showSuccess("courseForm", "Course registration submitted successfully.");
  }
});

// Validate fields when user leaves each input for quicker feedback.
[
  "contactName",
  "contactEmail",
  "contactPhone",
  "contactAddress",
  "contactMessage",
  "contactService",
].forEach((id) => {
  const el = document.getElementById(id);
  const eventName = el.tagName === "SELECT" ? "change" : "blur";
  el.addEventListener(eventName, () => {
    validateContactForm();
    clearSuccess("contactForm");
  });
});

[
  "courseName",
  "courseEmail",
  "coursePhone",
  "courseSelect",
  "courseDate",
].forEach((id) => {
  const el = document.getElementById(id);
  const eventName =
    el.tagName === "SELECT" || el.type === "date" ? "change" : "blur";
  el.addEventListener(eventName, () => {
    validateCourseForm();
    clearSuccess("courseForm");
  });
});

document.querySelectorAll('input[name="studyMode"]').forEach((radio) => {
  radio.addEventListener("change", () => {
    validateCourseForm();
    clearSuccess("courseForm");
  });
});

document.getElementById("contactTerms").addEventListener("change", () => {
  validateContactForm();
  clearSuccess("contactForm");
});

document.getElementById("courseTerms").addEventListener("change", () => {
  validateCourseForm();
  clearSuccess("courseForm");
});
