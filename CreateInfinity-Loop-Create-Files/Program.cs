
string fileName = "C:\\Users\\Public\\Desktop\\";
string NewFileName = "";
int x = 1;

while (x != 50)
{
    NewFileName = fileName + "file_" + x.ToString() ;

    using (FileStream fs = File.Create(NewFileName));
    x++;
}



