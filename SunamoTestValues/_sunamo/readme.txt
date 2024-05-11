tyhle třídy tu už nechat
nemůžu zde importovat SunamoShared, ani jako package, ani jako project
v obou případech

1>E:\vs\Projects\_ut2\sunamo.Tests\cmd.Tests\cmd.Tests.csproj : error NU1106: Unable to satisfy conflicting requests for 'SunamoXlf': SunamoXlf (>= 23.12.9.1) (via project/SunamoCmd 1.0.0), SunamoXlf (>= 23.12.9.1) (via project/SunamoShared 23.12.15.1) Framework: (.NETCoreApp,Version=v8.0)

jinými slovy, cmd.Tests.csproj importuje SunamoCmd a SunamoShared jež oba importují nuget SunamoXlf

