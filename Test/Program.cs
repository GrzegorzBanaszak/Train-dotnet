Teacher teacher = new Teacher();

Student student1 = new Student("Sophia", new List<Subject>{
    new Subject(99),
    new Subject(86),
    new Subject(87),
    new Subject(98),
    new Subject(100),
});

Student student2 = new Student("Andrew", new List<Subject>{
    new Subject(92),
    new Subject(89),
    new Subject(81),
    new Subject(96),
    new Subject(90),
});

Student student3 = new Student("Emma", new List<Subject>{
    new Subject(90),
    new Subject(85),
    new Subject(87),
    new Subject(98),
    new Subject(68),
});

teacher.rateStrudent(student1);
teacher.rateStrudent(student2);
teacher.rateStrudent(student3);

student1.displayScores();
student2.displayScores();
student3.displayScores();