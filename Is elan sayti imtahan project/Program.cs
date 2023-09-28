using Is_elan_sayti_imtahan_project;
using Newtonsoft.Json;
using System.ComponentModel.Design.Serialization;
using System.Net.NetworkInformation;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Xml.Linq;

var EmployeeList = new List<Employee>();
var WorkerList = new List<Worker>();
List<Notification> workerNatification = new List<Notification>();
List<Notification> employeeNatification = new List<Notification>();
List<WorkerLogin> workerLogins = new List<WorkerLogin>();
List<EmployeeLogin> employeeLogins = new List<EmployeeLogin>();
void createObjects()
{
    //-----------------------------------------Languages-------------------------------------------------------------

    Language Turk = new("Turk", "a3");
    Language English = new("Turk", "High advanced");
    Language Azerbaycan = new("Turk", "b1");
    List<Language> Languages1 = new();
    Languages1.Add(Turk);
    Languages1.Add(English);
    Languages1.Add(Azerbaycan);

    Language Espanyol = new("Espanyol", "b3");
    Language Spanish = new("Spanish", "a1");
    List<Language> Languages2 = new();
    Languages2.Add(Espanyol);
    Languages2.Add(Spanish);

    Language Franch = new("Franch", "c1");
    Language Rus = new("Rus", "c4");
    List<Language> Languages3 = new();
    Languages3.Add(Franch);
    Languages3.Add(Rus);


    Language Ukraina = new("Ukraina", "d1");
    Language Turkmenistan = new("Turkmenistan", "d3");
    List<Language> Languages4 = new();
    Languages4.Add(Franch);
    Languages4.Add(Rus);

    Language Kurt = new("Kurt", "a2");
    Language Suriye = new("Suriye", "High advanced");
    List<Language> Languages5 = new();
    Languages5.Add(Franch);
    Languages5.Add(Rus);

    //-----------------------------------------Languages-------------------------------------------------------------





    //--------------------------------------------CVC----------------------------------------------------------------

    Cv cv1 = new(false, "Proqramist", "Step it", 567.9, "C#,C++,Python", "Microsoft,Amazon", new DateOnly(2018, 1, 16), new DateOnly(2023, 4, 19), Languages1, true, true, true);
    Cv cv2 = new(false, "Dizayner", "Memar inshaat", 457.4, "Corona,AutoCad", "Edel,Zeferoglu", new DateOnly(2021, 4, 26), new DateOnly(2022, 3, 29), Languages2, false, false, true);
    List<Cv> Cvs1 = new();
    Cvs1.Add(cv1);
    Cvs1.Add(cv2);


    Cv cv3 = new(true, "Shop asistant", "BDU", 231.5, "Shoping,saler", "OBA,BRAVO,ALL,MEGA STORE", new DateOnly(2016, 11, 8), new DateOnly(2020, 7, 7), Languages3, true, false, true);
    Cv cv4 = new(true, "Admistrator", "ADNSU", 639.9, "nezaret,meslehet vermek", "28 Moll,Deniz moll", new DateOnly(2015, 1, 9), new DateOnly(2019, 4, 10), Languages3, true, false, false);
    List<Cv> Cvs2 = new();
    Cvs2.Add(cv3);
    Cvs2.Add(cv4);


    Cv cv5 = new(false, "Memarliq", "Memar inshaat", 382.2, "dizaynerlik,boyaciliq,ustaliq", "Hacioglu", new DateOnly(2010, 11, 11), new DateOnly(2022, 11, 11), Languages3, true, true, true);
    List<Cv> Cvs3 = new();
    Cvs3.Add(cv5);

    //--------------------------------------------CVC----------------------------------------------------------------





    //------------------------------------------Worker----------------------------------------------------------------


    Worker w1 = new Worker(Guid.NewGuid(), "Eli", "Hemzeyev", "Quba", "0507716677", 19, Cvs1);
    Worker w2 = new Worker(Guid.NewGuid(), "Fariz", "Osmanov", "Quba", "0516983141", 24, Cvs2);
    Worker w3 = new Worker(Guid.NewGuid(), "Besir", "Suleymanli", "Gence", "0502346807", 30, Cvs3);

    WorkerList.AddRange(new[] { w1, w2, w3 });

    var serializationResultForWorkers = JsonConvert.SerializeObject(WorkerList);
    File.WriteAllText("workers.json", serializationResultForWorkers);

    //------------------------------------------Worker----------------------------------------------------------------






    //-----------------------------------------Employee---------------------------------------------------------------
    Employee e1 = new Employee(Guid.NewGuid(), "Mehemmed", "Hemzeyev", "Quba", "0508736678", 18, new Vakansiya(1, "Memar", 2000, 4500));

    Employee e2 = new Employee(Guid.NewGuid(), "Pervin", "Ageyev", "Samaxi", "0500982445", 18, new Vakansiya(2, "Proqramist", 1000, 1500));
    Employee e3 = new Employee(Guid.NewGuid(), "Rubail", "rehmanli", "Qebele", "0503330078", 18, new Vakansiya(3, "Shop asistant", 2300, 3100));

    EmployeeList.AddRange(new[] { e1, e2, e3 });

    var serializationResultForEmployee = JsonConvert.SerializeObject(EmployeeList);
    File.WriteAllText("employees.json", serializationResultForEmployee);

    //-----------------------------------------Employee---------------------------------------------------------------

    //-----------------------------------------Notification------------------------------------------------------------

    Notification n1 = new Notification("Pervin", $" Employeri terefinden Eli Hemzeyev -e gonderilen message: Sizi isi almaq isdeyirik\nMaas teklifi: ", 34567);
    Notification n2 = new Notification("Besir", $" terefinden gonderilen mesaj {"Men oz isimde pesekaram.5 il bu isle mesgul olmusam "}\nMaas isteyi:", 1300);
    workerNatification.Add(n1);
    employeeNatification.Add(n2);

    var serializationResultForWorkerNotification = JsonConvert.SerializeObject(workerNatification);
    File.WriteAllText("workersNotification.json", serializationResultForWorkerNotification);

    var serializationResultForEmployeeNotification = JsonConvert.SerializeObject(employeeNatification);
    File.WriteAllText("employeesNotification.json", serializationResultForEmployeeNotification);

    //-----------------------------------------Notifaction-----------------------------------------------------------


    //-----------------------------------------Login------------------------------------------------------------------

    WorkerLogin wl1 = new WorkerLogin("maga40", "4040");
    WorkerLogin wl2 = new WorkerLogin("qwerty", "qweqwe");
    WorkerLogin wl3 = new WorkerLogin("mehemmed123", "maga1245");
    workerLogins.AddRange(new[] { wl1, wl2, wl3 });
    var workerLoginJson = JsonConvert.SerializeObject(workerLogins);
    File.WriteAllText("workersLogin.json", workerLoginJson);

    EmployeeLogin el1 = new EmployeeLogin("master34", "3434");
    EmployeeLogin el2 = new EmployeeLogin("error404", "er1245");
    EmployeeLogin el3 = new EmployeeLogin("survivor", "12345");
    employeeLogins.AddRange(new[] { el1, el2, el3 });
    var employeeLoginJson = JsonConvert.SerializeObject(employeeLogins);
    File.WriteAllText("employeesLogin.json", employeeLoginJson);

    //-----------------------------------------Login-------------------------------------------------------------------
}






while (true)
{
    try
    {
        if (!File.Exists("test.json"))
        {
            createObjects();
            var pp = JsonConvert.SerializeObject("1");
            File.WriteAllText("test.json", pp);
        }

        var testResultFromFileForEmployee = File.ReadAllText("employees.json");
        var newEmployeeList = JsonConvert.DeserializeObject<List<Employee>>(testResultFromFileForEmployee);

        var testResultFromFileForWorker = File.ReadAllText("workers.json");
        var newWorkerList = JsonConvert.DeserializeObject<List<Worker>>(testResultFromFileForWorker);

        var testResultFromFileForWorkerNotification = File.ReadAllText("workersNotification.json");
        var newWorkerNotification = JsonConvert.DeserializeObject<List<Notification>>(testResultFromFileForWorkerNotification);

        var testResultFromFileForEmployeeNotification = File.ReadAllText("employeesNotification.json");
        var newEmployeeNotification = JsonConvert.DeserializeObject<List<Notification>>(testResultFromFileForEmployeeNotification);

        var workersLoginJson = File.ReadAllText("workersLogin.json");
        var newWrokersLogin = JsonConvert.DeserializeObject<List<WorkerLogin>>(workersLoginJson);

        var employeesLoginJson = File.ReadAllText("employeesLogin.json");
        var newEmployeesLogin = JsonConvert.DeserializeObject<List<EmployeeLogin>>(employeesLoginJson);

        while (true)
        {

            Console.WriteLine("1.Worker Login\n2.Employee Login\n3.Create new worker login\n4.Create new employee login");
            string? loginChoice = Console.ReadLine();

            if (loginChoice == "1")
            {
                int checkLogin = 0;
                Console.WriteLine("User name daxil edin: ");
                string userName = Console.ReadLine();

                Console.WriteLine("Passwordu daxil edin: ");
                string password = Console.ReadLine();

                for (int m = 0; m < newWrokersLogin.Count; m++)
                {
                    if (userName == newWrokersLogin[m].UserName && password == newWrokersLogin[m].Password)
                    {
                        checkLogin++;
                        Console.WriteLine("1.Show all worker\n2.Show all vakansiya\n3.Choice vakansiya\n4.Show notification\n5.Save\n6.Create worker");
                        string choiceWorker = Console.ReadLine();

                        if (choiceWorker == "1")
                        {
                            for (int i = 0; i < newWorkerList.Count; i++)
                            {
                                Console.WriteLine(newWorkerList[i]);
                            }
                        }
                        else if (choiceWorker == "2")
                        {
                            for (int i = 0; i < newEmployeeList.Count; i++)
                            {
                                Console.WriteLine($"{newEmployeeList[i].Name} isci axtaranin vakansiyasi\n{newEmployeeList[i].Vacancies}");
                            }
                        }
                        else if (choiceWorker == "3")
                        {
                            int ID = 0;
                        IncorrectExperience:
                            Console.WriteLine("Vakansiyanin id-sin daxil edin");
                            try
                            {
                                int id = int.Parse(Console.ReadLine());
                                ID = id;
                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto IncorrectExperience;
                            }

                            int check = 0;
                            int check2 = 0;

                            for (int i = 0; i < newEmployeeList.Count; i++)
                            {
                                if (newEmployeeList[i].Vacancies.Id == ID)
                                {
                                    check++;
                                    Console.WriteLine("Hansi isci bu vakansiyani isdeyirse adin daxil edin:");
                                    string vakansiyaName = Console.ReadLine();

                                    for (int j = 0; j < newWorkerList.Count; j++)
                                    {
                                        if (newWorkerList[j].Name == vakansiyaName)
                                        {
                                            check2++;
                                            int Salary = 0;
                                        IncorrectExperience2:
                                            Console.WriteLine("Ne qeder maas isdeyirsinizse onu daxil edin:");

                                            try
                                            {
                                                int salary = int.Parse(Console.ReadLine());
                                                Salary = salary;
                                            }

                                            catch (Exception ex)
                                            {
                                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                                File.AppendAllText("log.json", logJson);
                                                goto IncorrectExperience2;
                                            }

                                            Console.WriteLine("Gonderilecek messageni daxil edin:");
                                            string message = Console.ReadLine();

                                            newEmployeeNotification.Add(new Notification(vakansiyaName, $" terefinden gonderilen mesaj {message}\nMaas isteyi:", Salary));
                                            employeeNatification.Add(new Notification(vakansiyaName, $" terefinden gonderilen mesaj {message}\nMaas isteyi:", Salary));

                                        }
                                    }
                                }
                            }

                            if (check == 0)
                            {
                                Console.WriteLine("Bu ide sahib vakansiya yoxdur!!!");
                            }

                            else if (check2 == 0)
                            {
                                Console.WriteLine("Bu adda isci yoxdur!!!");
                            }
                        }

                        else if (choiceWorker == "4")
                        {
                            for (int j = 0; j < newWorkerNotification.Count; j++)
                            {
                                Console.WriteLine("-----------Notification------------");
                                Console.WriteLine(newWorkerNotification[j] + "\n");
                            }
                        }

                        else if (choiceWorker == "5")
                        {

                            var serializationResultForWorkerNotification = JsonConvert.SerializeObject(newWorkerNotification);
                            File.WriteAllText("workersNotification.json", serializationResultForWorkerNotification);

                            var aaa = JsonConvert.SerializeObject(newWorkerList);
                            File.WriteAllText("workers.json", aaa);
                        }

                        else if (choiceWorker == "6")
                        {
                        I1:
                            Console.WriteLine("Workerin adin daxil edin:");
                            string Name = "";
                            try
                            {
                                string name = Console.ReadLine();
                                if (name.Length < 3)
                                {
                                    throw new NameException();
                                }
                                else
                                {
                                    Name = name;
                                }
                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto I1;
                            }
                        I2:
                            Console.WriteLine("Workerin soyadin daxil edin:");
                            string Surname = "";
                            try
                            {
                                string surname = Console.ReadLine();
                                if (surname.Length < 5)
                                {
                                    throw new SurnameException();
                                }
                                else
                                {
                                    Surname = surname;
                                }
                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto I2;
                            }
                        I3:
                            Console.WriteLine("Workerin sheherin daxil edin:");
                            string Sheher = "";
                            try
                            {
                                string sheher = Console.ReadLine();
                                if (sheher.Length < 3)
                                {
                                    throw new SheherException();
                                }
                                else
                                {
                                    Sheher = sheher;
                                }
                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto I3;
                            }
                        I4:
                            Console.WriteLine("Workerin nomresin daxil edin:");
                            string Phone = "";

                            try
                            {
                                string phone = Console.ReadLine();
                                if (phone.Length != 10)
                                {
                                    throw new PhoneException();
                                }
                                else
                                {
                                    Phone = phone;
                                }
                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto I4;
                            }

                        Incorrect:
                            Console.WriteLine("Workerin yasin daxil edin");
                            int Age = 0;
                            try
                            {
                                int age = int.Parse(Console.ReadLine());
                                if (age < 18)
                                {
                                    throw new AgeException();
                                }
                                else
                                {
                                    Age = age;
                                }
                            }

                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto Incorrect;
                            }
                        Inc11:
                            Console.WriteLine("Workerin dovlet isinde isleyirse true eks halda false daxil edin");
                            bool GovermentWork = true;
                            try
                            {
                                bool govermentWork = bool.Parse(Console.ReadLine());
                                GovermentWork = govermentWork;
                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto Inc11;
                            }

                            Console.WriteLine("Workerin ixtisasin daxil edin");
                            string trade = Console.ReadLine();

                            Console.WriteLine("Workerin mektebin daxil edin");
                            string school = Console.ReadLine();

                        Incorrect2:
                            Console.WriteLine("Workerin balin daxil edin");
                            double Bal = 0.0;
                            try
                            {
                                double bal = double.Parse(Console.ReadLine());
                                if (bal > 700.0)
                                {
                                    throw new AcceptanceScoreException();
                                }
                                else
                                {
                                    Bal = bal;
                                }
                            }

                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto Incorrect2;
                            }

                            Console.WriteLine("Workerin bacariqlarin daxil edin");
                            string skils = Console.ReadLine();

                            Console.WriteLine("Workerin islediyi sirketleri daxil edin");
                            string company = Console.ReadLine();
                        Incorrect3:
                            Console.WriteLine("Workerin ise basladigi ili daxil edin");
                            int StartYear = 0;
                            try
                            {
                                int startYear = int.Parse(Console.ReadLine());
                                StartYear = startYear;
                                if(startYear>DateTime.Now.Year || startYear < 1950) 
                                {
                                    throw new DateTimeException();
                                }
                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto Incorrect3;
                            }
                        Incorrect4:
                            Console.WriteLine("Workerin ise basladigi ayi daxil edin");
                            int StartMonth = 0;
                            try
                            {
                                int startMonth = int.Parse(Console.ReadLine());
                                StartMonth = startMonth;
                                if (startMonth > 12 || startMonth < 0) 
                                {
                                    throw new DateTimeException();
                                }
                            }

                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto Incorrect4;
                            }
                        Incorrect5:
                            Console.WriteLine("Workerin ise basladigi gunu daxil edin");
                            int StartDay = 0;
                            try
                            {
                                int startDay = int.Parse(Console.ReadLine());
                                StartDay = startDay;
                                if(startDay>30 || startDay < 0) 
                                {
                                    throw new DateTimeException();
                                }
                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto Incorrect5;
                            }

                        Incorrect6:
                            Console.WriteLine("Workerin ise bitirdiyi ili daxil edin");
                            int EndYear = 0;
                            try
                            {
                                int endYear = int.Parse(Console.ReadLine());
                                EndYear = endYear;
                                if (endYear > DateTime.Now.Year || endYear < 1950)
                                {
                                    throw new DateTimeException();
                                }

                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto Incorrect6;
                            }

                        Incorrect7:
                            Console.WriteLine("Workerin ise bitirdiyi ayi daxil edin");
                            int EndMonth = 0;
                            try
                            {
                                int endMonth = int.Parse(Console.ReadLine());
                                EndMonth = endMonth;
                                if (endMonth > 12 || endMonth < 0)
                                {
                                    throw new DateTimeException();
                                }
                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto Incorrect7;
                            }

                        Incorrect8:
                            Console.WriteLine("Workerin ise bitirdiyi gunu daxil edin");
                            int EndDay = 0;
                            try
                            {
                                int endDay = int.Parse(Console.ReadLine());
                                EndDay = endDay;
                                if (endDay > 30 || endDay < 0)
                                {
                                    throw new DateTimeException();
                                }
                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto Incorrect8;
                            }
                        Incorrect9:
                            Console.WriteLine("Worker nece dil bilir");
                            int CountLanguage = 0;

                            try
                            {
                                int countLanguage = int.Parse(Console.ReadLine());
                                CountLanguage = countLanguage;
                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto Incorrect9;
                            }

                            var languages = new List<Language>();
                            for (int i = 0; i < CountLanguage; i++)
                            {
                                Console.WriteLine("Dili daxil edin");
                                string? language = Console.ReadLine();

                                Console.WriteLine("Level daxil edin");
                                string? level = Console.ReadLine();

                                var l1 = new Language(language, level);
                                languages.Add(l1);
                            }
                        Inc10:
                            Console.WriteLine("Workerin ferqlenme diplomu varsa true eks halda false daxil edin");
                            bool HonorDiploma = false;
                            try
                            {
                                bool honorDiploma = bool.Parse(Console.ReadLine());
                                HonorDiploma = honorDiploma;
                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto Inc10;
                            }
                        Inc1:
                            Console.WriteLine("Workerin gitlinki  varsa true eks halda false daxil edin");
                            bool GitLink = true;
                            try
                            {
                                bool gitlink = bool.Parse(Console.ReadLine());
                                GitLink = gitlink;
                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto Inc1;
                            }

                        Inc2:
                            Console.WriteLine("Workerin linkedini varsa true eks halda false daxil edin");
                            bool Linkedin = true;
                            try
                            {
                                bool linkedin = bool.Parse(Console.ReadLine());
                                Linkedin = linkedin;
                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto Inc2;
                            }

                            var newCvs = new List<Cv>();
                            Cv cv = new Cv(GovermentWork, trade, school, Bal, skils, company, new DateOnly(StartYear, StartMonth, StartDay), new DateOnly(EndYear, EndMonth, EndDay), languages, HonorDiploma, GitLink, Linkedin);
                            newCvs.Add(cv);

                            Worker newWorker = new Worker(Guid.NewGuid(), Name, Surname, Sheher, Phone, Age, newCvs);

                            WorkerList.Add(newWorker);
                            newWorkerList.Add(newWorker);
                        }

                        else
                        {
                            throw new WarningException();
                        }
                    }
                }
                if (checkLogin == 0)
                {
                    throw new FalseException();
                }
            }

            else if (loginChoice == "2")
            {
                Console.WriteLine("User name daxil edin: ");
                string userName = Console.ReadLine();

                Console.WriteLine("Passwordu daxil edin: ");
                string password = Console.ReadLine();
                int checkLogin = 0;

                for (int e = 0; e < newEmployeesLogin.Count; e++)
                {
                    if (userName == newEmployeesLogin[e].UserName && password == newEmployeesLogin[e].Password)
                    {
                        checkLogin++;
                        Console.WriteLine("1.Show all employee\n2.Show all cvis\n3.Choice cvi\n4.Show notification\n5.Create Employee\n6.Save");
                        string choiceEmployee = Console.ReadLine();

                        if (choiceEmployee == "1")
                        {
                            for (int i = 0; i < newEmployeeList.Count; i++)
                            {
                                Console.WriteLine(newEmployeeList[i]);
                            }
                        }

                        else if (choiceEmployee == "2")
                        {
                            Console.WriteLine("1.Dovlet isinde isleyenlerin cvisi");
                            Console.WriteLine("2.Dovlet isinde islemeyenlerin cvisi");
                            Console.WriteLine("3.Butun iscilerin cvisi\nSecim edin:");
                            string choice = Console.ReadLine();

                            if (choice == "1")
                            {
                                Console.WriteLine("-----------------Dovlet isinde isleyenlerin cvileri--------------------");
                                for (int i = 0; i < newWorkerList.Count; i++)
                                {
                                    for (int j = 0; j < newWorkerList[i].Cvs.Count; j++)
                                    {
                                        if (newWorkerList[i].Cvs[j].GovernmentWork == true)
                                        {
                                            Console.WriteLine("\t" + newWorkerList[i].Name + newWorkerList[i].Surname + "-in svisi\n");
                                            Console.WriteLine(newWorkerList[i].Cvs[j]);
                                        }

                                    }
                                }
                            }

                            else if (choice == "2")
                            {
                                Console.WriteLine("-----------------Dovlet isinde islemeyenlerin cvileri--------------------");
                                for (int i = 0; i < newWorkerList.Count; i++)
                                {
                                    for (int j = 0; j < newWorkerList[i].Cvs.Count; j++)
                                    {
                                        if (newWorkerList[i].Cvs[j].GovernmentWork == false)
                                        {
                                            Console.WriteLine("\t" + newWorkerList[i].Name + " " + newWorkerList[i].Surname + "-in cvisi\n");
                                            Console.WriteLine(newWorkerList[i].Cvs[j]);
                                        }

                                    }
                                }
                            }

                            else if (choice == "3")
                            {
                                Console.WriteLine("-------------------------Butun iscilerin cvileri-----------------------------");
                                for (int i = 0; i < newWorkerList.Count; i++)
                                {
                                    Console.WriteLine("\t" + newWorkerList[i].Name + " " + newWorkerList[i].Surname + "-in cvileri\n");
                                    newWorkerList[i].showCvs();
                                }
                            }

                            else
                            {
                                throw new WarningException();
                            }


                        }
                        else if (choiceEmployee == "3")
                        {
                            Console.WriteLine("Cvideki ixtisasi daxil edin");
                            string trade = Console.ReadLine();
                            int check = 0;
                            int check2 = 0;

                            for (int i = 0; i < newWorkerList.Count; i++)
                            {
                                for (int j = 0; j < newWorkerList[i].Cvs.Count; j++)
                                {
                                    if (newWorkerList[i].Cvs[j].Specialty == trade)
                                    {
                                        check++;
                                        Console.WriteLine("Hansi employee bu cvini isdeyirse adin daxil etsin");
                                        string cvsName = Console.ReadLine();
                                        for (int k = 0; k < newEmployeeList.Count; k++)
                                        {

                                            if (newEmployeeList[k].Name == cvsName)
                                            {
                                                check2++;
                                            Inc11:
                                                Console.WriteLine("Maasin miqdarin daxil edin:");
                                                int Salary = 0;
                                                try
                                                {
                                                    int salary = int.Parse(Console.ReadLine());
                                                    Salary = salary;
                                                }
                                                catch (Exception ex)
                                                {
                                                    var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                                    File.AppendAllText("log.json", logJson);
                                                    goto Inc11;
                                                }
                                                Console.WriteLine("Isciye gonderilecek messageni daxil edin: ");
                                                string message = Console.ReadLine();

                                                Notification n1 = new Notification(cvsName, $" Employeri terefinden {newWorkerList[i].Name} {newWorkerList[i].Surname} -e gonderilen message: {message}\nMaas teklifi: ", Salary);

                                                newWorkerNotification.Add(n1);
                                                workerNatification.Add(n1);

                                            }
                                        }
                                    }
                                }
                            }

                            if (check == 0)
                            {
                                Console.WriteLine("Bu ixtisasda cvi yoxdur!!!");
                            }

                            else if (check2 == 0)
                            {
                                Console.WriteLine("Bu adda employee yoxdur!!!");
                            }
                        }

                        else if (choiceEmployee == "4")
                        {
                            for (int j = 0; j < newEmployeeNotification.Count; j++)
                            {
                                Console.WriteLine("-----------Notification------------");
                                Console.WriteLine(newEmployeeNotification[j] + "\n");
                            }
                        }



                        else if (choiceEmployee == "5")
                        {
                        Inc1:
                            Console.WriteLine("Employeenin adin daxil edin: ");
                            string Name = "";
                            try
                            {
                                string name = Console.ReadLine();
                                if (name.Length < 3)
                                {
                                    throw new NameException();
                                }
                                else
                                {

                                    Name = name;
                                }
                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto Inc1;
                            }
                        Inc2:
                            Console.WriteLine("Employeenin soyadin daxil edin: ");
                            string Surname = "";
                            try
                            {
                                string surname = Console.ReadLine();
                                if (surname.Length < 5)
                                {
                                    throw new SurnameException();
                                }
                                else
                                {
                                    Surname = surname;
                                }
                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto Inc2;
                            }
                        Inc3:
                            Console.WriteLine("Employeenin sheherin daxil edin: ");
                            string Sheher = "";
                            try
                            {
                                string sheher = Console.ReadLine();
                                if (sheher.Length < 3)
                                {
                                    throw new SheherException();
                                }
                                else
                                {
                                    Sheher = sheher;
                                }
                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto Inc3;
                            }
                        Inc4:
                            Console.WriteLine("Employeenin nomresin daxil edin: ");
                            string Phone = "";
                            try
                            {
                                string phone = Console.ReadLine();
                                if (phone.Length != 10)
                                {
                                    throw new PhoneException();
                                }
                                else
                                {
                                    Phone = phone;
                                }
                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto Inc4;
                            }

                        Inc5:
                            Console.WriteLine("Employeenin yasin daxil edin: ");
                            int Age = 0;
                            try
                            {
                                int age = int.Parse(Console.ReadLine());

                                if (age < 18)
                                {
                                    throw new AgeException();
                                }
                                else
                                {
                                    Age = age;
                                }

                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto Inc5;
                            }
                        Inc6:
                            Console.WriteLine("Vakansiyanin id-sin  daxil edin: ");
                            int Id = 0;
                            try
                            {
                                int id = int.Parse(Console.ReadLine());
                                Id = id;
                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto Inc6;
                            }

                            Console.WriteLine("Axtarilan iscinin ixtisasin daxil edin: ");
                            string trade = Console.ReadLine();
                        Inc7:
                            Console.WriteLine("Axtarilan iscinin maasinin birincisi araliqin daxil edin: ");
                            int Salary1 = 0;
                            try
                            {
                                int salary1 = int.Parse(Console.ReadLine());
                                Salary1 = salary1;
                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto Inc7;
                            }
                        Inc8:
                            Console.WriteLine("Axtarilan iscinin maasinin ikinci araliqin  daxil edin: ");
                            int Salary2 = 0;
                            try
                            {
                                int salary2 = int.Parse(Console.ReadLine());
                                Salary2 = salary2;
                            }
                            catch (Exception ex)
                            {
                                var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
                                File.AppendAllText("log.json", logJson);
                                goto Inc8;
                            }

                            Employee newEmployee = new Employee(Guid.NewGuid(), Name, Surname, Sheher, Phone, Age, new Vakansiya(Id, trade, Salary1, Salary2));
                            Console.WriteLine(newEmployee);
                            EmployeeList.Add(newEmployee);
                            newEmployeeList.Add(newEmployee);
                        }

                        else if (choiceEmployee == "6")
                        {

                            var serializationResultForEmployeeNotification = JsonConvert.SerializeObject(newEmployeeNotification);
                            File.WriteAllText("employeesNotification.json", serializationResultForEmployeeNotification);

                            var aaa = JsonConvert.SerializeObject(newEmployeeList);
                            File.WriteAllText("employees.json", aaa);
                        }

                        else
                        {
                            throw new WarningException();
                        }
                    }
                }
                if (checkLogin == 0)
                {
                    throw new FalseException();
                }


            }

            else if (loginChoice == "3")
            {
                Console.WriteLine("User name daxil edin:");
                string userName = Console.ReadLine();

                Console.WriteLine("Password daxil edin:");
                string password = Console.ReadLine();

                WorkerLogin newLogin = new WorkerLogin(userName, password);
                newWrokersLogin.Add(newLogin);

                var a = JsonConvert.SerializeObject(newWrokersLogin);
                File.WriteAllText("workersLogin.json", a);
            }

            else if (loginChoice == "4")
            {
                Console.WriteLine("User name daxil edin:");
                string userName2 = Console.ReadLine();

                Console.WriteLine("Password daxil edin:");
                string password2 = Console.ReadLine();

                EmployeeLogin Login = new EmployeeLogin(userName2, password2);
                newEmployeesLogin.Add(Login);
                employeeLogins.Add(Login);

                var b = JsonConvert.SerializeObject(employeeLogins);
                File.WriteAllText("employeesLogin.json", b);
            }
            else 
            {
                throw new WarningException();
            }
        }
    }

    catch (FalseException ex)
    {


        addExceptionForLogJson(ex);
    }

    catch (NameException ex)
    {
        addExceptionForLogJson(ex);
    }

    catch (SurnameException ex)
    {
        addExceptionForLogJson(ex);
    }

    catch (SheherException ex)
    {
        addExceptionForLogJson(ex);
    }

    catch (AgeException ex)
    {
        addExceptionForLogJson(ex);
    }

    catch (PhoneException ex)
    {
        addExceptionForLogJson(ex);
    }

    catch (AcceptanceScoreException ex)
    {
        addExceptionForLogJson(ex);
    }

    catch (WarningException ex)
    {
        addExceptionForLogJson(ex);
    }

    catch (Exception ex)
    {
        addExceptionForLogJson(ex);
    }
}

void addExceptionForLogJson(Exception ex) 
{
    var logJson = JsonConvert.SerializeObject(new Log(ex.Message, DateTime.Now));
    File.AppendAllText("log.json", logJson);

    Console.WriteLine(ex.Message);
}