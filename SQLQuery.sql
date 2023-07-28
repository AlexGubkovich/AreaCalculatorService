use Example

SELECT p.Name, c.Name 
	FROM Products as p LEFT JOIN Categories as c 
		ON EXISTS (SELECT * FROM CategoryProduct WHERE CategoryId = c.Id AND ProductId = p.Id) 
ORDER BY p.Id