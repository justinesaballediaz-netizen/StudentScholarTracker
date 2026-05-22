# 🎓 ScholarTrack: Student & Teacher Information System

**ScholarTrack** is a comprehensive desktop application built with C# and Windows Forms. It is designed to streamline academic administration by managing student records, teacher profiles, course enrollments, and grade tracking. 

This project utilizes a straightforward, low-code database approach using Microsoft Access to handle relational data efficiently.

---

## ✨ Key Features

### 👨‍💻 Admin Information Hub
* **Student Management:** Full CRUD (Create, Read, Update, Delete) capabilities for student records.
* **Teacher Management:** Assign and track teacher profiles, departments, and credentials.
* **Course & Enrollment Tracking:** Manage course codes and track which students are enrolled in specific classes.
* **Data Import/Export:** * Import batch student and teacher data directly from **Excel** files.
    * Export official Master Lists to **PDF** and **Excel** formats.

### 📝 Teacher Grading Hub
* **Class Roster:** Teachers can view students enrolled specifically in their assigned courses.
* **Grade Encoding:** Input and update Midterm and Final grades (using a 1.0 - 5.0 scale).
* **Report Generation:** Export an Official Class Grades Report to PDF for personal records.

---

## 🛠️ Technology Stack

* **Language:** C# (.NET)
* **UI Framework:** Windows Forms (WinForms)
* **Database:** Microsoft Access (`.accdb`) via `OleDb` connections
* **Dependencies / NuGet Packages:**
    * `ClosedXML`: For generating and reading Excel (`.xlsx`) templates.
    * `iTextSharp`: For rendering professional, formatted PDF reports.

---

## 🚀 Getting Started

Follow these instructions to get a copy of the project up and running on your local machine.

### Prerequisites
* Visual Studio (2019 or newer recommended)
* Microsoft Access Database Engine (if not already installed with Office)

### Installation & Setup
1. **Clone the repository:**
   ```bash
   git clone [https://github.com/justinesaballediaz-netizen/StudentScholarTracker.git](https://github.com/justinesaballediaz-netizen/StudentScholarTracker.git)
