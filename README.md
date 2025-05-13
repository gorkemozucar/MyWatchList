# My Watch List

Film ve dizilerinizi takip edebileceğiniz basit bir web uygulaması.

## Kullanılan Teknolojiler

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Bootstrap 5
- HTML5 & CSS3

## Kurulum

1. Projeyi klonlayın:
```bash
git clone https://github.com/gorkemozucar/MyWatchList.git
```

2. `appsettings.json` dosyasındaki veritabanı bağlantı dizesini kendi SQL Server bağlantınızla güncelleyin:
"ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=MyWatchList;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

3. Package Manager Console'da aşağıdaki komutları çalıştırın:
```bash
Update-Database
```

4. Uygulamayı çalıştırın:
```bash
dotnet run
```

## Özellikler

- Film ve dizi ekleme
- İzleme durumu takibi
- İzleme tarihi kaydetme
- Düzenleme ve silme işlemleri 