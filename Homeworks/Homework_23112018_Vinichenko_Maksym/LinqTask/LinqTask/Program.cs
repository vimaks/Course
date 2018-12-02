using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = Dataset.People;
            // 1) Получить число мужчин в коллекции; число женщин
            int manCount = people.Where(p => p.Gender == Gender.Man).ToArray().Length;   //.Count() вместо .ToArray().Length - избавит от необходимости приводить к массиву
            int womanCount = people.Where(p => p.Gender == Gender.Woman).ToArray().Length;

            // 2) Отсортировать персонажей по фамилии потом по имени, выбрать их описание в формате $"{Name} {SurName}, age
            //{ Age} lives in {City}, {Country}. He (или she, решить тернарным опертором) is {Occupation} and makes 
            //{ AnnualIncome} a year. {Family status to string}, speaks {Languages Count} languages
            var sortedPeople = people.OrderBy(p => p.SurName).ThenBy(p => p.Name).ToArray();
            var selected = people.Select(p => $"{p.Name} {p.SurName}, {p.Age} lives in {p.HomeAddress.City.Name}, {p.HomeAddress.City.Country.Name}, {((p.Gender == Gender.Man) ? "He" : "She")}" +
                $" is {p.Occupation} and makes {p.AnnualIncome} a year. {p.FamilyStatus.ToString()}, speaks {p.Languages.Count()} languages.");

            // 3)Найти тех, кто живет в странах с  насилением больше 80 миллионов
            var moreThenEighteenMillion = people.Where(p => p.HomeAddress.City.Country.Population > 80000000).ToArray();

            // 4) Найти средний доход в группе персонажей (return decimal Average()) с высшим образованием (выше HECert - аналого нашего двухгодичного "младшего специалиста")
            decimal averageIncome = (people.Where(p => p.EducationLevel >= EducationLevel.HECert)).Average(p => p.AnnualIncome);

            // 5) Найти тех, чей годовой доход превышает годовой доход в их стране
            var aboveAverageIncomePeople = people.Where(p => p.AnnualIncome > p.HomeAddress.City.Country.AvgIncome).ToArray();
            // 6) Найти максимальное число языков, которым владеет персонаж (return int Max()
            int maxLanguagesCount = people.Max(p => p.Languages.Count());
            // 7) Найти виртуозного полиглота (для которого число языков равняется числу из п.6)
            var Poliglot = people.First(p => p.Languages.Count() == people.Max(pe => pe.Languages.Count()));
            // 8) Найти персонажа, который не владеет языком страны, в которой он проживает. Если такого нет - вернуть null
            var NoSpeakPerson = people.FirstOrDefault(p => !p.Languages.Contains(p.HomeAddress.City.Country.Language));
            // 9) Найти людей, проживающих в Германии, упорядочить по возрасту от большего до меньшего, выбрать в формате $"{Name} {Surname} {Age} {City}"
            var germansPeople = (people.Where(p => p.HomeAddress.City.Country.Id == 3)).OrderByDescending(p => p.Age).Select(p => $"{p.Name} {p.SurName} {p.Age} {p.HomeAddress.City.Name}");
            // 10)Найти процентную долю тех, кто состоит в браке от общего числа персонажей
            double marriedPeopleCount = (double)people.Where(p => p.FamilyStatus == FamilyStatus.Married).ToArray().Count() / (double)people.Count() * (double)100;
            // 11) Найти тех, кто владеет двумя и более языками но получает зарплату ниже средней по их стране
            var somePeople = people.Where(p => p.Languages.Count() >= 2).Where(p => p.AnnualIncome < p.HomeAddress.City.Country.AvgIncome).ToArray();
            // 12) Найти единственного кандидата наук, если такого нет либо если выборка больше 1 - вернуть ошибку
            Person personPhD = people.Single(p => p.EducationLevel == EducationLevel.PhD);
            // 13) Найти людей из испаноговорящих стран, вернуть в формате $"{Name} {Occupation} {City} {Country}"
            var spainSpeakPeople = people.Where(p => p.HomeAddress.City.Country.Language == (Dataset.Langs["es"])).Select(p => $"{p.Name} {p.Occupation} {p.HomeAddress.City.Name} {p.HomeAddress.City.Country.Name}");
            // 14) Найти персонажа, который живет в городе с наименьшим населением (относительно места проживания других персонажей)
            Person lowestPopulationLiver = people.FirstOrDefault(p => p.HomeAddress.City.Population == people.Min(pe => pe.HomeAddress.City.Population));
            // 15) Найти персонажа, который живет в городе с наименьшим абсолютным населением (город с наименьшим населением в списке городов), 
            //     если такого нет - вернуть налл
            Person absolutLowestPopulationLiver = people.FirstOrDefault(p => p.HomeAddress.City.Population == Dataset.Cities.Min(c => c.Value.Population));
            // 17) Определить, какая доля людей, владеющих английским, проживает не в англоговорящих странах по отношению ко всем людям из списка, которые владеют английским

            var enSpeakAll = people.Where(p => p.Languages.Contains(Dataset.Langs["en"])).ToArray();
            var noEnCountry = enSpeakAll.Where(p => p.HomeAddress.City.Country.Language != Dataset.Langs["en"]).ToArray();
            double result = (double)noEnCountry.Count() / (double)enSpeakAll.Count() * (double)100;
            // 18) Найти самого богатого персонажа
            Person maxIncomePerson = people.FirstOrDefault(p => p.AnnualIncome == people.Max(pe => pe.AnnualIncome));  //Скорее First  - кто то да будет всегда самым богатым
            // 19) Найти персонажа с наименьшим доходом в Британии
            Person minIncomePersonBritan = people.Where(p => p.HomeAddress.City.Country.Id == 1).FirstOrDefault(p => p.AnnualIncome == people.Where(pe => pe.HomeAddress.City.Country.Id == 1).Min(pe => pe.AnnualIncome));
            // 20) Отсортировать персонажей по доходу по нисходящей, потом по имени и по фамилии по восходящей
            var sortedPeopleIncome = people.OrderByDescending(p => p.AnnualIncome).ThenBy(p => p.Name).ThenBy(p => p.SurName).ToArray();


        }
    }
}
