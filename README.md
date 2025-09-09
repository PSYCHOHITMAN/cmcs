# Contract Monthly Claim System (CMCS) 

## Overview
This repository contains **Part 1** of the Portfolio of Evidence (PoE) for PROG6212.  
The project is a **front-end prototype** of the Contract Monthly Claim System (CMCS), designed using **ASP.NET Core MVC** with internal CSS styling.

The CMCS aims to streamline the process of submitting and approving monthly claims for **Independent Contractor (IC) lecturers**.  
This first phase focuses on **UI design and navigation only**. Future phases will add backend logic and database integration.

---

## Features (Prototype Stage)
- **Login Page**: Simple login form with a clean, centered layout (no navbar/footer).
- **Home Page**: Dashboard showing quick actions for lecturers and administrators.
- **Claims Page**: Mock submission form and table to view claims and statuses.
- **Approvals Page**: Pending claims list with mock approve/reject actions.
- **Lecturers Page**: Interface to manage lecturer information.

*Note: All pages are non-functional at this stage (front-end only).*

---

## UML Class Diagram (Database Design - For Future Stages)
The prototype includes a database design for upcoming phases.  
Entities include:
- **User** (login + role management)  
- **Lecturer** (staff info + hourly rates)  
- **Claim** (hours worked, totals, statuses)  
- **SupportingDocument** (uploaded files)  
- **Approval** (records coordinator/manager actions)  



## Project Plan (Part 1)
- **Week 1–2**: Requirements & UML design  
- **Week 3–4**: Build ASP.NET MVC prototype (UI only)  
- **Week 5**: UI testing and refinements  
- **Week 6**: Documentation and submission  

Future parts:
- **Part 2** → Add backend logic and claim approval workflows  
- **Part 3** → Integrate with database (CRUD) and finalize the system  

---

## Getting Started
1. Clone the repository:  
   ```bash
   git clone https://github.com/your-username/CMCS-Prototype.git
