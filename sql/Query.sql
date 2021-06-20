/*помимо описанных столбцов в таблицу Product было добавлено поле 
Repository для связи Товаров со складом*/
select 
	r.Number,
	r.City,
	r.Adress
from Repository as r
join Product as p 
on r.Id = p.Repository
	where p.Art = 1 --Var

select 
	p.Name,
	count(p.Name) as Count
from Product as p
	where p.Repository = 1 --Var
		group by p.Name

select 
	p.Name,
	r.City
from Product as p
join Repository as r
on p.Repository = r.Id
	Where r.City = 'Казань' --Var

select 
	r.Number
from Repository as r
join Product as p 
on r.Id = p.Repository
	where p.Art = 3 --Var
	order by p.Repository
	