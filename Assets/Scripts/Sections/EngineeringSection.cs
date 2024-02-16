using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineeringSection : Section
{
    void Start()
    {
        sectionName = "Engineering Section";
        
        base.Start();
        
        baseSalary = new Dictionary<string, float>();
        baseSalary[Seniority.JUNIOR] = 1500f;
        baseSalary[Seniority.SEMISENIOR] = 3000f;
        baseSalary[Seniority.SENIOR] = 5000f;

        salaryIncrements = new Dictionary<string, float>();
        salaryIncrements[Seniority.JUNIOR] = 0.05f;
        salaryIncrements[Seniority.SEMISENIOR] = 0.07f;
        salaryIncrements[Seniority.SENIOR] = 0.1f;

        for (var i = 0; i < 32; i++) {
            this.addEmployee(new Employee(this, Seniority.JUNIOR));
        }
        for (var i = 0; i < 68; i++) {
            this.addEmployee(new Employee(this, Seniority.SEMISENIOR));
        }
        for (var i = 0; i < 50; i++) {
            this.addEmployee(new Employee(this, Seniority.SENIOR));
        }
    }
}
