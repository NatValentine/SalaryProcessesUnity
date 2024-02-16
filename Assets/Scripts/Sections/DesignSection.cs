using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesignSection : Section
{
    void Start()
    {
        sectionName = "Design Section";
        
        base.Start();
        
        baseSalary = new Dictionary<string, float>();
        baseSalary[Seniority.JUNIOR] = 800f;
        baseSalary[Seniority.SENIOR] = 2000f;

        salaryIncrements = new Dictionary<string, float>();
        salaryIncrements[Seniority.JUNIOR] = 0.04f;
        salaryIncrements[Seniority.SENIOR] = 0.07f;

        for (var i = 0; i < 15; i++) {
            this.addEmployee(new Employee(this, Seniority.JUNIOR));
        }
        for (var i = 0; i < 10; i++) {
            this.addEmployee(new Employee(this, Seniority.SENIOR));
        }
    }
}
