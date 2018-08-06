Git Commands: 

--add all files to track
git add . 

-- commit changes 
git commit -m "Comment"

-- push to master
git push -u origin master



DotNet .core EF 

--Init migrations 
dotnet ef migrations add InitDb

--updates DB 
dotnet ef database update

--roll back changes 
dotnet ef database update 0

--remove migrations
dotnet ef migrations remove
