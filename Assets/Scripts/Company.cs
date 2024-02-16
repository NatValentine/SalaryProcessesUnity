using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Company : MonoBehaviour
{
    public List<Section> sections;

    public List<GameObject> displays;

    public List<Employee> employees() {
        List<Employee> employees = new List<Employee>();
        foreach (Section section in this.sections) {
            employees.AddRange(section.getEmployees());
        }
        return employees;
    }

    public void incrementSalaries() {
        foreach (var section in this.sections) 
        {
            var keys = new List<string>(section.baseSalary.Keys);

            foreach (var key in keys)
            {
                section.baseSalary[key] = section.baseSalary[key] * (1f + section.salaryIncrements[key]);
            }
        }

        displaySections();
    }

    public void logSalaries() {
        foreach (var section in sections) 
        {
            Debug.Log(section.sectionName);
            foreach (var key in section.baseSalary.Keys) {
                Debug.Log(key + ": " + section.baseSalary[key]);
            }
        }
    }

    private void displaySections() {
        //CEO Section is a special case
        displays[0].transform.Find("txtSectionName").GetComponent<Text>().text = sections[0].sectionName;
        displays[0].transform.Find("txtTotalEmployees").GetComponent<Text>().text = "Total Employees: " + sections[0].getEmployees().Count  + " - $" + sections[0].getSalary(Seniority.CEO);

        for (int i = 1; i < sections.Count; i++) {
            displays[i].transform.Find("txtSectionName").GetComponent<Text>().text = sections[i].sectionName;
            displays[i].transform.Find("txtTotalEmployees").GetComponent<Text>().text = "Total Employees: " + sections[i].getEmployees().Count;
            displays[i].transform.Find("txtJuniorEmployees").GetComponent<Text>().text = "Junior Employees: " + sections[i].getJuniorEmployees().Count + " - $" + sections[i].getSalary(Seniority.JUNIOR);
            displays[i].transform.Find("txtSemiseniorEmployees").GetComponent<Text>().text = "Semisenior Employees: " + sections[i].getSemiSeniorEmployees().Count + " - $" + sections[i].getSalary(Seniority.SEMISENIOR);
            displays[i].transform.Find("txtSeniorEmployees").GetComponent<Text>().text = "Senior Employees: " + sections[i].getSeniorEmployees().Count + " - $" + sections[i].getSalary(Seniority.SENIOR);
        }
    }

    void Start() {
        // logSalaries();
        displaySections();
    }
}
