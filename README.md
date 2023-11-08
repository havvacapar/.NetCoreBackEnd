# .NetCoreBackEnd

<p>E-ticaret siteleri için kullanılabilir bir mimari amaçlanmıştır.<br>
.NetCore ile geliştirilmiştir.<br>

  
  <tr>
<td align="left"><a href="/dotnet/core/blob/main/release-notes/3.1/README.md">.NET Core 3.1</a></td>
<td align="left"><a href="https://devblogs.microsoft.com/dotnet/announcing-net-core-3-1/" rel="nofollow">December 3, 2019</a></td>
<td align="left"><a href="/dotnet/core/blob/main/release-policies.md">LTS</a></td>
<td align="left"><a href="/dotnet/core/blob/main/release-notes/3.1/3.1.19/3.1.19.md">3.1.19</a></td>
<td align="left">December 3, 2022</td>
</tr>

Kayıt olma fonksiyonunda kullanıcının şifresi veritabanında hash ve salt yöntemleri ile depolanır. <br>
Kullanıcının güvenliği bu şekilde sağlanır.

<h3>FONKSİYONLAR</h3>

Bütün fonksiyonlar CRUD mantığı ile Katmanlı Mimariye uygun yazılmıştır. <br>
<h3>
1.Kullanıcı fonksiyonları: </h3>
<ul> 
  <li> 1.1:Register </li>
  <li>1.2:Login </li>
  </ul><br>
<h3>
2.Ürün İşlemleri</h3>
<ul>
<li>  2.1:Ekle</li>
  <li>2.2:Sil</li>
  <li>2.3:Güncelle</li>
  <li>2.4:Listele</li>
  </ul><br>
  
  <h3>
3.Yetkin Kullanıcılar:</h3>
 
 Yetkin kullanıcılar, ürünler için; ekleme, silme ve güncelleme işlemleri yapabilir. 
 Bunun için JWT kullanılarak bir token oluşturulur ve yetkinlik kontrolü yapılır.
 <ul>
 
 <li>3.1:User</li>
 <li>3.2:OperationClaim</li>
 <li>3.3:UserOperationClaim</li>
  </ul><br>
 <h3>
4.Sepet  İşlemleri</h3>
<ul>
<li>  4.1:Ekle</li>
  <li>4.2:Sil</li></ul><br>
  
 <h3>
5.Doğrulama İşlemleri</h3>
<ul>
<li> 
  5.1:Ürün Bilgisi doğrulama</li>
  <li> 5.2:Kullanıcı Bilgisi Doğrulama </li></ul><br>
  
  <h3>
6.Kullanılan Paketler</h3>
<ul>
  <li><a href="https://www.nuget.org/packages/FluentValidation.AspNetCore/">6.1:FluentValidation</a></li>
  <li><a href="https://www.nuget.org/packages/Autofac/">6.2:Autofac</a></li>
  <li><a href="https://www.nuget.org/packages/Autofac.Extensions.DependencyInjection/7.2.0-preview.1">6.3:Autofac.Extensions.DependencyInjection</a></li>
  <li><a href="https://www.nuget.org/packages/Autofac.Extras.DynamicProxy/">6.4:Autofac.Extras.DynamicProxy</a></li>
  <li><a href="https://www.nuget.org/packages/Microsoft.Extensions.Identity.Core/6.0.0-rc.1.21452.15">6.5:Microsoft.Extensions.Identity.Core</a></li>
  <li><a href="https://www.nuget.org/packages/Microsoft.AspNetCore.Http/">6.6:Microsoft.AspNetCore.Http</a></li>
  <li><a href="https://www.nuget.org/packages/Microsoft.AspNetCore.Http.Abstractions/">6.7:Microsoft.AspNetCore.Http.Abstractions</a></li>
  <li><a href="https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/6.0.0-rc.1.21452.10">6.8:Microsoft.EntityFrameworkCore.SqlServer</a></li>
  <li><a href="https://www.nuget.org/packages/Microsoft.Extensions.Configuration/6.0.0-rc.1.21451.13">6.9:Microsoft.Extensions.Configuration</a></li>
  <li><a href="https://www.nuget.org/packages/Microsoft.Extensions.Configuration.Binder/6.0.0-rc.1.21451.13">6.10:Microsoft.Extensions.Configuration.Binder</a></li>
  <li><a href="https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer/6.0.0-rc.1.21452.15">6.11:Microsoft.AspNetCore.Authentication.JwtBearer </a></p></li></ul>
  


  
  
  

 
 
 
 


