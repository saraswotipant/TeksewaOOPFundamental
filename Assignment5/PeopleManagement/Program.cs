﻿string filePath = @"D:\Git\TeksewaOOPFundamental\Assignment5\PeopleManagement";
List<Person> people = await CSVParser.ParseCSV(filePath);
await PeopleReport.SaveMales(people, filePath);
await PeopleReport.SaveFemales(people, filePath);
await PeopleReport.SaveDotComUsers(people, filePath);