Day27
---
1.  Реализовать кастомный обработчик запроса - IHttpHandler, который возвращает изображение, находящееся в некотором каталоге приложения.

2.  Реализовать кастомный обработчик маршрута - IRouteHandler, который используется для обработки маршрута c URL-паттерном Image/{id} 
и устанавливает для дальнейшей обработки запроса IHttpHandler из п.1.

Примеры ниже.

![](https://github.com/RomanGutovec/NET1.A.2018.Gutovec.27/blob/master/Task1/Pictures/example1.png)


![](https://github.com/RomanGutovec/NET1.A.2018.Gutovec.27/blob/master/Task1/Pictures/example2.png)


![](https://github.com/RomanGutovec/NET1.A.2018.Gutovec.27/blob/master/Task1/Pictures/example3.png)

3.  Реализовать кастомный управляемый модуль - IHttpModule, 
который, в случае, если данные маршрута предоставляются согласно URL-паттерну Image/{id}, предоставляет в качестве обработчика 
запроса IHttpHandler из п.1. Примеры запроса выглядят аналогично п. 2.
