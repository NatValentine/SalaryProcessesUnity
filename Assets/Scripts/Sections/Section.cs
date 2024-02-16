using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Section : MonoBehaviour
{
    public string sectionName;
    private List<Employee> juniorEmployees;
    private List<Employee> semiseniorEmployees;
    private List<Employee> seniorEmployees;

    public Dictionary<string, float> baseSalary;

    public Dictionary<string, float> salaryIncrements;

    public float getSalary(string seniority) {
        if (baseSalary.ContainsKey(seniority)) {
            return baseSalary[seniority];
        }

        return  0;
    }

    public virtual List<Employee> getEmployees() {
        List<Employee> employees = new List<Employee>();
        employees.AddRange(juniorEmployees);
        employees.AddRange(semiseniorEmployees);
        employees.AddRange(seniorEmployees);

        return employees;
    }

    public List<Employee> getJuniorEmployees() {
        return juniorEmployees;
    }

    public List<Employee> getSemiSeniorEmployees() {
        return semiseniorEmployees;
    }

    public List<Employee> getSeniorEmployees() {
        return seniorEmployees;
    }

    public virtual void addEmployee(Employee employee) {
        if (employee.getSeniority() == Seniority.JUNIOR) {
            juniorEmployees.Add(employee);
        }
        if (employee.getSeniority() == Seniority.SEMISENIOR) {
            semiseniorEmployees.Add(employee);
        } 
        if (employee.getSeniority() == Seniority.SENIOR) {
            seniorEmployees.Add(employee);
        }
    }

    public void Start() {
        juniorEmployees = new List<Employee>();
        semiseniorEmployees = new List<Employee>();
        seniorEmployees = new List<Employee>();
    }
}
