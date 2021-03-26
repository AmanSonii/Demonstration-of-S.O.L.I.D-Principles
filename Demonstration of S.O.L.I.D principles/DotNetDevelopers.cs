using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstration_of_S.O.L.I.D_principles
{
    public abstract class Developers
    {
        public string Name { get; set; }

        public string Technology { get; set; }
        public int WorkingHours()
        {
            return 8;
        }
        public abstract int GetTableNumber();

    }


    public class DotNetDeveloper : Developers
    {
        public override int GetTableNumber()
        {
            return 5;
        }
    }

    public class JavaDeveloper : Developers
    {
        public override int GetTableNumber()
        {
            return 6;
        }
    }
}
public interface ITechnicalEmployee
{
    int GetWorkingHours();
}

public interface IDeveloper
{
    void DoCoding();
    void UnitTesting();
}

public interface IQA
{
     void RaiseIssues();
}

public class Developer : ITechnicalEmployee,IDeveloper
{
    public void DoCoding()
    {
        // It is the work of a developer
    }

    public void UnitTesting()
    {
        // It is the work of a developer
    }

    public int GetWorkingHours()
    {
        return 8;
    }
}
public class QA : ITechnicalEmployee, IQA
{
   public int GetWorkingHours()
    {
        return 8;
    }

    public void RaiseIssues()
    {
        //Raise issues
    }
    
}



