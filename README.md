# Attendly MVP

**Unified SaaS for Attendance, School Management, and POS – Phase 1 MVP**

---

## Overview
Attendly is a cloud-based SaaS platform combining:
- Employee and student attendance tracking
- School attendance with parent notifications
- Basic POS for small shops

Phase 1 focuses on **software-only clocking**, allowing web and mobile apps to simulate attendance and sales. Hardware integration (biometric devices, RFID) and payment gateways will be added in later phases.

---

## Tech Stack

**Backend**
- .NET 8, ASP.NET Core Web API
- Clean Architecture (Domain, Application, Infrastructure, API)
- PostgreSQL (multi-tenant database)
- JWT authentication & ASP.NET Identity

**Frontend**
- Web: React + TypeScript + Tailwind
- Mobile: React Native

**Notifications**
- Email: SendGrid
- SMS: Twilio / Clickatell

---

## Phase 1 MVP Scope

| Module | Features | Notes |
|--------|---------|-------|
| Attendance | Clock in/out, timesheets | Web + Mobile apps, simulated clocking only |
| School Attendance | Teacher marking, parent notifications | Email/SMS notifications |
| POS Lite | Product catalog, sales, inventory | Web dashboard only |
| Notifications | Email/SMS | Push notifications optional for Phase 1 |
| Billing | Optional manual/free trial | Payment integration Phase 2 |
| Hardware | N/A | Fully software-based |

---

## System Architecture (Phase 1)

