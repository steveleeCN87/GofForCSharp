using System.Collections.Generic;
using DesignPattern.Visitor.Element;
using DesignPattern.Visitor.Visitor;

namespace DesignPattern.Visitor.ObjectStructure
{
    /// <summary>
    /// 对象结构类：EmployeeList
    /// </summary>
    public class EmployeeList
    {
        private IList<IEmployee> empList = new List<IEmployee>();

        public void AddEmployee(IEmployee emp)
        {
            this.empList.Add(emp);
        }

        public void Accept(Department handler)
        {
            foreach (var emp in empList)
            {
                emp.Accept(handler);
            }
        }
    }
}
