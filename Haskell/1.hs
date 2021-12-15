sumaPar :: [(Integer,Integer)] -> [Integer]
sumaPar [] = []
sumaPar (x:xs) = (fst x + snd x) : sumaPar xs