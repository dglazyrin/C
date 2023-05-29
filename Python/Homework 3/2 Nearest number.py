# Задача 18: Требуется найти в массиве A[1..N] самый близкий по величине элемент к заданному числу X
import random
dlina=random.randint(10,99)
stroka=[random.randint(1,100) for i in range(dlina)]
print(f'У нас есть такой массив {stroka}')
chislo=int(input("Какое число будем искать - "))
for i in range(dlina-1):
     if abs(stroka[0]-chislo)<abs(stroka[1]-chislo):
          stroka.pop(1)
     else:
          stroka.pop(0)          
print(f'Ближайшее к вашему числу - {stroka[0]}')