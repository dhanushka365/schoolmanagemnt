# https://www.entityframeworktutorial.net/efcore/fluent-api-in-entity-framework-core.aspx


Student:

Has a one-to-one relationship with StudentAddress.
Has a many-to-many relationship with Course.

![manytomany-db-diagram](https://github.com/user-attachments/assets/6e342304-250f-4b12-9edc-15263415e8ce)



StudentAddress:

Has a one-to-one relationship with Student.



Teacher:

Has a one-to-many relationship with Course.


Course:

Has a many-to-many relationship with Student.
Has a many-to-one relationship with Teacher.

