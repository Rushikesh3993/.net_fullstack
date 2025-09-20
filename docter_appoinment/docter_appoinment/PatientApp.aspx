<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PatientApp.aspx.cs" Inherits="docter_appoinment.PatientApp" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Patient Appointment Form</title>
    <link rel="stylesheet" href="style.css" />

<script>
    function validateForm() {
        let name = document.getElementById("fullName").value.trim();
        let email = document.getElementById("email").value.trim();
        let phone = document.getElementById("phone").value.trim();
        let date = document.getElementById("appointmentDate").value;
        let time = document.getElementById("appointmentTime").value;
        let reason = document.getElementById("reason").value.trim();

        // Full Name
        if (name === "") {
            alert("Please enter your full name");
            return false;
        }

        // Email
        let emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        if (!emailPattern.test(email)) {
            alert("Please enter a valid email address");
            return false;
        }

        // Indian Phone Number (10 digits, starts with 6/7/8/9)
        let phonePattern = /^[6-9]\d{9}$/;
        if (!phonePattern.test(phone)) {
            alert("Please enter a valid 10-digit Indian phone number starting with 6, 7, 8, or 9");
            return false;
        }

        // Date validation
        if (date === "") {
            alert("Please select an appointment date");
            return false;
        }
        let today = new Date();
        today.setHours(0, 0, 0, 0); // Midnight
        let selectedDate = new Date(date);

        if (selectedDate < today) {
            alert("Past dates are not allowed for appointments");
            return false;
        }

        // Time validation
        if (time === "") {
            alert("Please select an appointment time");
            return false;
        }

        if (selectedDate.getTime() === today.getTime()) {
            let currentTime = new Date();
            let [hours, minutes] = time.split(":");
            let selectedTime = new Date();
            selectedTime.setHours(hours, minutes, 0, 0);

            if (selectedTime < currentTime) {
                alert("Past time is not allowed for today's appointment");
                return false;
            }
        }

        // Reason
        if (reason.length < 5) {
            alert("Please enter a reason (at least 5 characters)");
            return false;
        }

        return true; // allow submit
    }
</script>

</head>
<body>
    <div class="container">
        <h1>Schedule Your Appointment</h1>
        <form action="SavePatientData.aspx" method="post" onsubmit="return validateForm();">
            <div class="form-group">
                <label for="fullName">Full Name:</label>
                <input type="text" id="fullName" name="pname" required />
            </div>
            <div class="form-group">
                <label for="email">Email:</label>
                <input type="email" id="email" name="pemail" required />
            </div>
            <div class="form-group">
                <label for="phone">Phone Number:</label>
                <input type="tel" id="phone" name="pphone" placeholder="e.g., 9876543210" required />
            </div>
            <div class="form-group">
                <label for="appointmentDate">Preferred Date:</label>
                <input type="date" id="appointmentDate" name="pdate" required />
            </div>
            <div class="form-group">
                <label for="appointmentTime">Preferred Time:</label>
                <input type="time" id="appointmentTime" name="ptime" required />
            </div>
            <div class="form-group">
                <label for="reason">Reason for Appointment:</label>
                <textarea id="reason" name="preason" rows="4" required></textarea>
            </div>
            <button type="submit">Submit Appointment</button>
        </form>
    </div>
</body>
</html>

<style>
    body {
        font-family: Arial, sans-serif;
        background-color: #f4f4f4;
        display: flex;
        justify-content: center;
        align-items: center;
        min-height: 100vh;
        margin: 0;
    }

    .container {
        background-color: #fff;
        padding: 30px;
        border-radius: 8px;
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        width: 100%;
        max-width: 500px;
    }

    h1 {
        text-align: center;
        color: #333;
        margin-bottom: 20px;
    }

    .form-group {
        margin-bottom: 15px;
    }

    label {
        display: block;
        margin-bottom: 5px;
        color: #555;
        font-weight: bold;
    }

    input[type="text"],
    input[type="email"],
    input[type="tel"],
    input[type="date"],
    input[type="time"],
    textarea {
        width: 100%;
        padding: 10px;
        border: 1px solid #ddd;
        border-radius: 4px;
        box-sizing: border-box;
        font-size: 16px;
    }

    textarea {
        resize: vertical;
    }

    button[type="submit"] {
        background-color: #007bff;
        color: white;
        padding: 12px 20px;
        border: none;
        border-radius: 4px;
        cursor: pointer;
        font-size: 16px;
        width: 100%;
        transition: background-color 0.3s ease;
    }

    button[type="submit"]:hover {
        background-color: #0056b3;
    }
</style>
