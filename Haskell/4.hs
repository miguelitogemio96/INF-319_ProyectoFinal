esBisiesto :: Integer -> Bool
esBisiesto x 
 |(mod x 4) == 0 = if ((mod x 100) == 0) && ((mod x 400) == 0) then False else True
 |otherwise = False