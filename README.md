# Academy Awards API
## By Garrett Brown

* _Date Created: Sept 14th 2021_
* _Last Updated: Oct 8th 2021_

#### By _Garrett Brown_


## Description

The Academy Awards, or the Oscars, are awards given since 1929 to honor artistic achievements in film and movies. Although they are an American Awards Ceremony, the Academy Awards are considered one of the most prestigious awards in film entertainment worldwide.

Like any nearly 100 year old institution, the Academy Awards have undergone many changes. Some award categories have been renamed, merged, or discontinued altogether. Movies  and actors that were cultural phenomenons have been reduced bar trivia questions. To keep all of this information straight, I have decided to lay it all out in an easy, searchable database, one that is scalable and reusable.

I will be working with information taken directly from the Academy Awards website, and I hope that this API will be a living document, updating as new awards happen. I also hope that it can be public, available for non-commercial use. 

##### Research and Activity Log

<details>
    <summary><span style="color:red"><strong>Click to Expand</strong></summary>

<strong>Research Log</strong>

* Sept 14th 2021 7:03 PM to 8:49 - Gathering Data in Excell. (106 min)
* Sept 20th 2021 7:45 PM to 9:25 - Gathering Data in Excell. (100 min)
* Sept 26th 2021 10:30 AM to 11:50 AM - Changing data, making edits. (80 min)
* Sept 26th 2021 11:50 AM to 1PM - Structuring API, creating API basics. (70 min)
* Sept 26th 2021 2:49 PM to 3:28 - Data maxmizing, Drawio. (39 min)
* Sept 26th 2021 3:29 PM to 4:45 - Data maxmizing, Drawio. (76 min)
* Sept 26th 2021 4:45 PM to 5:00 PM - Drawio, standup in class. (15 min)
* Sept 28th 2021 6 PM to 7 - Standup in class, creating schema. (60 min)
* Oct 2nd 2021 3 PM to 3:30 - Schema Analysis. (30 min)
* Oct 3rd 2021 9:30 AM - 10:40 AM - API. (70 min)

<strong>FILE TRANSFER TO NEW REPOSITORY, LOST GIT HISTORY.</strong>

* Oct 3rd 2021 10:40 AM - 1PM - API. (140 min)
* Oct 3rd 2021 2:20 PM - 5:30 PM - API, GET, PUT, PUSH. (190 min)
* Oct 3rd 2021 7 PM - 8:30 PM - API, fully functional (90 min)

Check in: 1,066 min, or 17.7666667 hours.

* Oct 6th 2021 6:45 PM - 8: 15 PM - Seeding Data. (90 min)
* Oct 6th 2021 8:15 PM - 9:05 PM - API. (50 min)
* Oct 6th 2021 9:05 PM - 11:40 PM - Seeding Database. (155 min)
* Oct 6th 2021 11:40 PM - 12:00 AM - Migration Issues Fixed. (20 min)
* Oct 8th 2021 4:15 PM - 5:40 PM - Integration of Swagger into API. (85 min)
https://docs.google.com/spreadsheets/d/1UJ5y-uzIn_iSlDE_9wPRfLr41qaUA9mbKf4w1CswyPA/edit#gid=121875076

</details>

##### User Stories
<details>
    <summary><span style="color:red"><strong>Expand to Read User Stories</strong></summary>
1. User needs to be able to use program.
2. This will get filled in later I assume.

</details>


## Setup/Installation Requirements

<details>
    <summary>Required Programs</summary>
    
1. An internet browser.
2. Visual Code Studio (or another code editor).
3. .NET

</details>

<details>
    <summary>Installation of Program</summary>

1. Open the terminal on your local machine and navigate to "Desktop."
2. Clone <b>Academy Award API</b> with the following git command `git clone https://github.com/GBProductions/Epicodus-Capstone`
3. Navigate to the top level of the repository with the command `cd Epicodus-Capstone`
4. In the CL, type in `git init`. 

</details>

<details>
    <summary>Configuration</summary>

### AppSettings

#### Instructions: `appsettings.json` Creation

1. Create a file in the root directory called `appsettings.json`. 
2. Add `appsettings.json` to `.gitignore`. Commit change in GIT.
3. Insert the following code into `appsettings.json`:
    
``` 
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=oscar_api;uid=root;[YOUR-PASSWORD];"
  }
}

```

4. Replace `[YOUR-PASSWORD]` with password you selected when installing MySQLWorkbench.
5. Replace database name with the name of your database (if necessary).
6. Replace port name with the port of your choice (if necessary).
7. In the root directory, run `dotnet ef databse update` 
8. In the root directory, run `dotnet ef databse restore`

This will recreate the database on your computer, using MySQLWorkbench. You can proceed to Startup.

</details>

## API Exploration
### Swagger
To explore Academy Award API with Swagger - Swashbuckle, go to your program directory and launch the program with `dotnet run`. Once the program is running, open a browser window and go to `http://localhost:5000/swagger`, and you will be able to navigate and have full CRUD functionality.

<details>
    <summary>Exploring Endpoints</summary>

### Endpoints

Basic URL: `https://localhost5000`

HTTP Request Structure (add after Basic URL)

```
| Route                      | Usage                 |   
|----------------------------|-----------------------|
| GET /api/Nominations           | Return all nominations    | 
| POST /api/Nominations          | Create new nomination     |
| GET /api/Nominations/{id}      | Return nomination by id   |
| PUT /api/Nominations/{id}      | Edit nomination by id     |
| DELETE /api/Nominations/{id}   | Delete nomination by id   |
```
### Path Parameters
Explanation of parameters for Nomination:

```
| Parameter      | Required? | Type   | Description                                             |
|----------------|-----------|--------|---------------------------------------------------------|
| Nominee        | yes       | string | Returns by name(s) of nominee.                          |
| Film           | yes       | string | Returns by name of film individual was nominated for.   |
| Year           | yes       | string | Returns by year nomination was announced                |
| Category       | yes       | string | Returns by category nomination was in.                  |
| CategoryActive | yes       | string | Returns categories by whether they are active or not.   |
| Winner         | yes       | string | Returns winners of a specific category.                 |
| Notes          | no        | string | Returns by assorted details associated with nomination. |
```

### Searching via Parameters
In order to search for animals matching a parameter, use this format:

```
GET /api/Nominations?{parameter}={search-term}
```

#### Example:
```
http://localhost:5001/api/Nominations?Film=Nomadland
```

In order to search for a specific animal matching multiple parameters, add a `&` between searches:

#### Example:
```
http://localhost:5001/api/Nomination?Winner=Yes&year=2020
```
</details>

## Known Bugs

_There are currently no known bugs._


## Support and contact details

_For assistance, please contact:_ 
* Garrett Brown <garrettpaulbrown@gmail.com>

## Technologies Used

_Academy Awards API_
* Visual Studios Code (VSCode)
* Github
* MarkDown
* C# 
* Entity Framework, .NET Core 5.0.1
* Swagger - Swashbuckle

## Licensing

```

MIT License

Copyright (c) 2021 GARRETT BROWN

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

```