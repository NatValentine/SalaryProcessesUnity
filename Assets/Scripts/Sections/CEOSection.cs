using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEOSection : Section
{
    private Employee ceo;

    void Start()
    {
        sectionName = "CEO Section";
        
        baseSalary = new Dictionary<string, float>();
        baseSalary[Seniority.CEO] = 20000f;

        salaryIncrements = new Dictionary<string, float>();
        salaryIncrements[Seniority.CEO] = 1f;

        addEmployee(new Employee(this, Seniority.CEO));
    }

    public override List<Employee> getEmployees() {
        List<Employee> listCEO = new List<Employee>();
        listCEO.Add(ceo);
        return listCEO;
    }

    public override void addEmployee(Employee employee) {
        this.ceo = employee;
    }
}
