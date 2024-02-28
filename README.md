# Итоговая контрольная по основному блоку
<br>
1. Создать репозиторий на GitHub<br>
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)<br>
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)<br>
4. Написать программу, решающую поставленную задачу<br>
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)<br><br>

### Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
```
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
```
## Решение
Создаем метод, который принимает исходный массив строк, и возвращает отсортированный массив строк.
В методе используем 2 цикла. 
Первый цикл нужен для того, чтобы по условию "длина строки в массиве <= 3" сосчитать количество таких строк. 
Создаём результирующий пустой массив, длина которого равна полученному количеству. 
Во втором цикле заполняем пустой массив по такому же условию ("длина строки в массиве <= 3").
Далее пишем метод, который распечатывает полученный массив в консоль.
Запускаем методы, чтобы протестировать программу.
