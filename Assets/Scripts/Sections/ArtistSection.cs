using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtistSection : Section
{
    void Start()
    {   
        sectionName = "Artist Section";
        
        base.Start();
        
        baseSalary = new Dictionary<string, float>();
        baseSalary[Seniority.SEMISENIOR] = 1200f;
        baseSalary[Seniority.SENIOR] = 2000f;

        salaryIncrements = new Dictionary<string, float>();
        salaryIncrements[Seniority.SEMISENIOR] = 0.25f;
        salaryIncrements[Seniority.SENIOR] = 0.05f;

        for (var i = 0; i < 20; i++) {
            this.addEmployee(new Employee(this, Seniority.SEMISENIOR));
        }
        for (var i = 0; i < 5; i++) {
            this.addEmployee(new Employee(this, Seniority.SENIOR));
        }
    }
}
