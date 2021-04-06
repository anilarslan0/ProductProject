# ProductProject

Product projesi .Net Core Freamework ve C# kullanılarak kodlanmış bir backend projesidir. Proje katmanlı mimari, SOLID prensipleri kullanılarak oluşturulmuştur.

1. Businnes Katmanı
2. Data Access Katmanı
3. Core Katmanı
4. Entities Katmanı
5. Web API Katmanı

- **Business:** Projemizin iş katmanıdır.İş kuralları, veri kontrolleri, validasyonlar, IoC Container'lar ve yetki kontrolleri kullanılmaktadır.
- **DataAccess:** Projenin, Veritabanı ile bağını kuran katmandır. Projemizde bu katmanda EntityFramework kullanılmıştır.
- **Core:** Projenin evrensel bölümlerinin bulunduğu katmandır. Bu katmanda bulunan yapılar her projede ortaktır.
- **Entities:** Veritabanındaki tablolarımızın projemizde nesne olarak kullanılması için oluşturulmuştur. DTO nesnelerinide barındırmaktadır.
- **WebAPI:** Prjenin Restful API Katmanıdır. Kullanılan methodlar: Get, Post, Put, Delete


## Kullanılan Teknolojiler
- Restful API
- Result Türleri
- Interceptor
- Autofac
 - IoC Containers
 - AOP, Aspect Oriented Programming
   - Caching
   - Performance
   - Transaction
   - Validation
- Fluent Validation
- Cache yönetimi
- JWT Authentication
- Repository Design Pattern
- Cross Cutting Concerns
- Extensions
 - Claim
 - Exception Middleware
 - Service Collection
 - Error Handling
   - Error Details
   - Validation Error Details
