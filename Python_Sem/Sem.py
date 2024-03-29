def Py_Sem():
    task = input('Введите номер задания. Для закрытия программы введите "0": ')
    match task:
        case "0": print('Закрытие программы...')
        case "1": Task1()
        case "2": Task2()
        case "3": Task3()
        case "4": Task4()
        case "5": Task5()
        case "6": Task6()
        case "7": Task7()
        case "8": Task8()
        case "9": Task9()
        case "10": Task10()
        case "11": Task11()
        case "12": Task12()
        case "13": Task13()
        case "14": Task14()
        case "15": Task15()
        case "16": Task16()
        case "17": Task17()
        case "18": Task18()
        case "19": Task19()
        case "20": Task20()
        case "21": Task21()
        case "22": Task22()
        case "23": Task23()
        case "24": Task24()
        case "25": Task25()
        case "26": Task26()
        case "27": Task27()
        case "28": Task28()
        case "29": Task29()
        case "30": Task30()
        case "31": Task31()
        case "32": Task32()
        case "33": Task33()
        case "34": Task34()
        case "35": Task35()
        case "36": Task36()
        case "37": Task37()
        case "38": Task38()
        case "39": Task39()
        case "41": Task41()
        case "43": Task43()
        case "44": Task44()
        case "45": Task45()
        case "47": Task47()
        case "49": Task49()
        case "51": Task51()
        case _:
            print('Неверный номер задачи!')
            Py_Sem()

def Task1():
    """
    За день машина проезжает n километров. Сколько
    дней нужно, чтобы проехать маршрут длиной m
    километров?
    Input: n = 700 m = 750
    Output: 2
    """
    print('ЗАДАЧА 1')
    import math
    n = int(input('Введите n: '))
    m = int(input('Введите m: '))
    print(math.ceil(m/n))
    Py_Sem()
def Task2():
    """
    Найдите сумму цифр трехзначного числа.
    Input: 123 
    Output: 6 
    """
    print('ЗАДАЧА 2')
    def sum_rec(x: int):
        return x if x == 0 else ((x % 10) + sum_rec(x//10))
    num = int(input('Введите число: '))
    print(sum_rec(num))
    Py_Sem()
def Task3():
    """
    В некоторой школе решили набрать три новых
    математических класса и оборудовать кабинеты для
    них новыми партами. За каждой партой может сидеть
    два учащихся. Известно количество учащихся в
    каждом из трех классов. Выведите наименьшее
    число парт, которое нужно приобрести для них.
    Input: 20 21 22
    Output: 32
    """
    print('ЗАДАЧА 3')
    import math
    num1 = int(input('Введите первое число: '))
    num2 = int(input('Введите второе число: '))
    num3 = int(input('Введите третье число: '))
    print(math.ceil(num1/2)+math.ceil(num2/2)+math.ceil(num3/2))
    Py_Sem()
def Task4():
    """
    Петя, Катя и Сережа делают из бумаги журавликов. Вместе
    они сделали S журавликов. Сколько журавликов сделал каждый
    ребенок, если известно, что Петя и Сережа сделали одинаковое
    количество журавликов, а Катя сделала в два раза больше журавликов,
    чем Петя и Сережа вместе?
    Input: 24 
    Output: 4 16 4
    """
    print('ЗАДАЧА 4')
    sum = int(input('Введите количество журавликов: '))
    Kat = sum//3*2
    Pet = Ser = Kat//4
    print(f"{sum} -> {Pet} {Kat} {Ser}" if sum%6==0 
          else 'Невозможно целочисленно распределить журавлики.')
    Py_Sem()
def Task5():
    """
    Вагоны в электричке пронумерованы натуральными
    числами, начиная с 1 (при этом иногда вагоны
    нумеруются от «головы» поезда, а иногда – с
    «хвоста»; это зависит от того, в какую сторону едет
    электричка). В каждом вагоне написан его номер.
    Витя сел в i-й вагон от головы поезда и обнаружил,
    что его вагон имеет номер j. Он хочет определить,
    сколько всего вагонов в электричке. Напишите
    программу, которая будет это делать или сообщать,
    что без дополнительной информации это сделать
    невозможно.
    Input: 3 4
    Output: 6
    """
    print('ЗАДАЧА 5')
    i = int(input('Введите i: '))
    j = int(input('Введите j: '))
    print((i+j-1) if (i+j-1)>0 
          else 'Невозможно определить количество вагонов')
    Py_Sem()
def Task6():
    """
    Вы пользуетесь общественным транспортом? Вероятно, вы
    расплачивались за проезд и получали билет с номером. Счастливым
    билетом называют такой билет с шестизначным номером, где сумма
    первых трех цифр равна сумме последних трех. Т.е. билет с номером
    385916 – счастливый, т.к. 3+8+5=9+1+6. Вам требуется написать
    программу, которая проверяет счастливость билета.
    Input: 385916 
    Output: yes
    """
    print('ЗАДАЧА 6')
    ticket = input('Введите шестизначный номер билета: ')
    if len(ticket) == 6:
        print('yes' if (int(ticket[0])+int(ticket[1])+int(ticket[2]))
              == (int(ticket[-1])+int(ticket[-2])+int(ticket[-3]))
              else 'no')
    else: 
        print('Неверное количество цифр!')
        Task6()
    Py_Sem()
def Task7():
    """
    Дано натуральное число. Требуется определить,
    является ли год с данным номером високосным. Если
    год является високосным, то выведите YES, иначе
    выведите NO. Напомним, что в соответствии с
    григорианским календарем, год является
    високосным, если его номер кратен 4, но не кратен
    100, а также если он кратен 400.
    Input: 2016
    Output: YES
    """
    print('ЗАДАЧА 7')
    year = int(input('Введите год: '))
    print('YES' if (year % 400 == 0) 
                or ((year % 4 == 0) and (year % 100 != 0))
                else 'NO')
    Py_Sem()
def Task8():
    """
    Требуется определить, можно ли от шоколадки размером n * m 
    долек отломить k долек, если разрешается сделать один разлом по
    прямой между дольками (то есть разломить шоколадку на два
    прямоугольника).
    Input: 3 2 4 
    Output: yes
    """
    print('ЗАДАЧА 8')
    n = int(input('Введите число n: '))
    m = int(input('Введите число m: '))
    k = int(input('Введите число k: '))
    print('yes' if (k%n==0 or k%m==0) else 'no')
    Py_Sem()
def Task9():
    """
    По данному целому неотрицательному n вычислите
    значение n!. N! = 1 * 2 * 3 * … * N (произведение всех
    чисел от 1 до N) 0! = 1 *Решить задачу используя цикл while*
    Input: 5
    Output: 120
    """
    print("ЗАДАЧА 9")
    n = int(input("Введите число N: "))
    if n == 0: print(1)
    else:
        count = 1
        res = 1
        while (count<=n):
            res*=count
            count+=1
        print(res)
    Py_Sem()
def Task10():
    """
    На столе лежат n монеток. Некоторые из них лежат вверх
    решкой, а некоторые – гербом. Определите минимальное число
    монеток, которые нужно перевернуть, чтобы все монетки были
    повернуты вверх одной и той же стороной. Выведите минимальное
    количество монет, которые нужно перевернуть.
    Input: 5 -> 1 0 1 1 0
    Output: 2
    """    
    from random import randint
    print("ЗАДАЧА 10")
    N = int(input("Введите количество монеток: "))
    heads = 0
    tails = 0
    for i in range(N):
        coin = randint(0, 1)
        print(coin, end=" ")
        if coin==1: heads+=1
        else: tails+=1 
    print()
    print(heads if heads<tails else tails)
    Py_Sem()
def Task11():
    """
    Дано натуральное число A > 1. Определите, каким по
    cчету числом Фибоначчи оно является, то есть
    выведите такое число n, что φ(n)=A. Если А не
    является числом Фибоначчи, выведите число -1.
    Input: 5
    Output: 6 
    """
    print("ЗАДАЧА 11")
    A = int(input("Введите число больше 1: "))
    flag = -1
    fib1, fib2 = 0, 1
    step = 2
    while (fib2 <= A):
        if fib2==A: 
            flag = step
            break
        else:
            fib1, fib2 = fib2, (fib1+fib2)
            step+=1
    print(flag)
    Py_Sem()
def Task12():
    """
    Петя и Катя – брат и сестра. Петя – студент, а Катя –
    школьница. Петя помогает Кате по математике. Он задумывает два
    натуральных числа X и Y (X,Y≤1000), а Катя должна их отгадать. Для
    этого Петя делает две подсказки. Он называет сумму этих чисел S и их
    произведение P. Помогите Кате отгадать задуманные Петей числа.
    Input: 5 6
    Output: 2 3
    """
    import math
    print("ЗАДАЧА 12")
    S = int(input("Введите сумму чисел X и Y: "))
    P = int(input("Введите произведение чисел X и Y: "))
    # P = x*y = x*(S-y)
    # P = -x**2 + S*x + 0
    # x**2 - S*x + P = 0
    D = (-S)**2-4*P
    if D < 0:
        print(f"S:{S} P:{P} -> решения для целых чисел нет")
    elif D==0:
        x = y = S/2
        if (int(x)==x and int(y)==y):
            print(f"S:{S} P:{P} -> x:{x} y:{y}")
        else:
            print(f"S:{S} P:{P} -> решения для целых чисел нет")
    else:
        x = (S+math.sqrt(D))/2
        if x<0: 
            x = (S-math.sqrt(D))/2
        y = S-x
        if (int(x)==x and int(y)==y):
            print(f"S:{S} P:{P} -> x:{x} y:{y}")
        else:
            print(f"S:{S} P:{P} -> решения для целых чисел нет")
    Py_Sem()    
def Task13():
    """
    Уставшие от необычно теплой зимы, жители решили узнать,
    действительно ли это самая длинная оттепель за всю историю
    наблюдений за погодой. Они обратились к синоптикам, а те, в
    свою очередь, занялись исследованиями статистики за
    прошлые годы. Их интересует, сколько дней длилась самая
    длинная оттепель. Оттепелью они называют период, в
    который среднесуточная температура ежедневно превышала
    0 градусов Цельсия. Напишите программу, помогающую
    синоптикам в работе.
    Пользователь вводит число N – общее количество
    рассматриваемых дней (1 ≤ N ≤ 100). В следующих строках
    располагается N целых чисел.
    Каждое число – среднесуточная температура в
    соответствующий день. Температуры – целые числа и лежат в
    диапазоне от –50 до 50
    Input: 6 -> -20 30 -40 50 10 -10
    Output: 2
    """     
    print("ЗАДАЧА 13")
    N = int(input("Введите число от 1 до 100: "))
    max_days = 0
    combo = 0
    if 1 <= N <= 100:
        for i in range(1, N+1):
            temp = int(input(f"Введите среднюю температуру в {i} день: "))
            if temp > 0: 
                combo+=1
            else: 
                combo=0
            if combo > max_days: max_days = combo 
        print(max_days)
    else: print("Введено неверное число")
    Py_Sem()
def Task14():
    """
    Требуется вывести все целые степени двойки (т.е. числа
    вида 2**k), не превосходящие числа N.
    Input: 10
    Output: 1 2 4 8
    """
    print("ЗАДАЧА 14")
    N = int(input("Введите число N: "))
    if N==0: print(f"{N} -> нет решения")
    else:
        print(f"{N} ->", end=" ")
        degree = 0
        while(2**degree<=N):
            print(2**degree, end=" ")
            degree+=1
        print()
    Py_Sem()
def Task15():
    """
    Иван Васильевич пришел на рынок и решил
    купить два арбуза: один для себя, а другой для тещи.
    Понятно, что для себя нужно выбрать арбуз
    потяжелей, а для тещи полегче. Но вот незадача:
    арбузов слишком много и он не знает как же выбрать
    самый легкий и самый тяжелый арбуз? Помогите ему!
    Пользователь вводит одно число N – количество
    арбузов. Вторая строка содержит N чисел,
    записанных на новой строчке каждое. Здесь каждое
    число – это масса соответствующего арбуза
    Input: 5 -> 5 1 6 5 9
    Output: 1 9
    """
    print("ЗАДАЧА 15")
    N = int(input("Введите количество арбузов: "))
    weight = int(input("Введите вес 1 арбуза: "))
    min, max = weight, weight
    for i in range(2, N+1):
        weight = int(input(f"Введите вес {i} арбуза: "))
        if weight < min: min = weight 
        if weight > max: max = weight 
    print(min, max)
    Py_Sem()
def Task16():
    """
    Требуется вычислить, сколько раз встречается некоторое
    число X в массиве A[1..N]. Пользователь в первой строке вводит
    натуральное число N – количество элементов в массиве. В последующих
    строках записаны N целых чисел A. Последняя строка содержит число X
    Input: 5, 1 2 3 4 5, 3
    Output: 1
    """
    print("ЗАДАЧА 16")
    list = []
    N = int(input("Введите количество элементов в массиве: "))
    for i in range(N):
        list.append(int(input(f"Введите {i+1} число: "))) 
    X = int(input("Введите число X: "))
    total = 0
    for item in list:
        total+=1 if item == X else 0
    print(total)
    Py_Sem()
def Task17():
    """
    Дан список чисел. Определите, сколько в нем
    встречается различных чисел.
    Input: [1, 1, 2, 0, -1, 3, 4, 4]
    Output: 6
    """
    print("ЗАДАЧА 17")
    from random import randint
    list_1 = [randint(-5, 5) for i in range(8)]
    print(list_1)
    print(len(set(list_1)))
    Py_Sem()
def Task18():
    """
    Требуется найти в массиве A[1..N] самый близкий по
    величине элемент к заданному числу X. Пользователь в первой строке
    вводит натуральное число N – количество элементов в массиве. В
    последующих строках записаны N целых чисел A. Последняя строка
    содержит число X
    Input: 5, 1 2 3 4 5, 6
    Output: 5
    """
    print("ЗАДАЧА 18")
    list = []
    N = int(input("Введите количество элементов в массиве: "))
    for i in range(N):
        list.append(int(input(f"Введите {i+1} число: "))) 
    X = int(input("Введите число X: "))
    elem = list[0]
    diff = abs(X-list[0])
    for item in list:
        if abs(X-item)<diff:
            elem = item
            diff = abs(X-item)
    print(elem)
    Py_Sem()
def Task19():
    """
    Дан список чисел. Определите, сколько в нем
    встречается различных чисел.
    Input: [1, 1, 2, 0, -1, 3, 4, 4]
    Output: 6
    """
    print("ЗАДАЧА 19")
    from random import randint
    list_1 = [i for i in range(randint(5, 10))]
    print(list_1)
    k = int(input("Введите число k: "))
    list_2 = []
    for i in range(k, len(list_1)): list_2.append(list_1[i])
    for i in range(k): list_2.append(list_1[i])
    print(list_2)
    q = input('Если хотите решить задачу с помощью рекурсии, нажмите "1": ')
    match q:
        case "1": 
            def ShiftRec(list: list, x: int):
                if x == 0: return list
                temp = list[0]
                for i in range(len(list)-1):
                    list[i] = list[i+1]
                list[-1] = temp
                return ShiftRec(list, x-1)
            print(list_1)
            ShiftRec(list_1, k)
            print(list_1)
            Py_Sem() 
        case _: Py_Sem() 
def Task20():
    """
    В настольной игре Скрабл (Scrabble) каждая буква имеет определенную
    ценность. Напишите программу, которая вычисляет стоимость введенного пользователем слова.
    Будем считать, что на вход подается только одно слово, которое содержит либо только
    английские, либо только русские буквы.
    Input: ноутбук
    Output: 12
    """
    dict = {
        "a":1, "e":1, "i":1, "o":1, "u":1, "l":1, 
        "n":1, "s":1, "t":1, "r":1,
        "d":2, "g":2, "b":3, "c":3, "m":3, "p":3,
        "f":4, "h":4, "v":4, "w":4, "y":4, "k":5,
        "j":8, "x":8, "q":10, "z":10,
        "а":1, "в":1, "е":1, "и":1, "н":1, "о":1, "р":1, "с":1, "т":1,
        "д":2, "к":2, "л":2, "м":2, "п":2, "у":2,
        "б":3, "г":3, "ё":3, "ь":3, "я":3, "й":4, "ы":4,
        "ж":5, "з":5, "х":5, "ц":5, "ч":5,
        "ш":8, "э":8, "ю":8, "ф":10, "щ":10, "ъ":10
    }
    word = input("Введите слово: ")
    score = 0
    try:
        for char in word:
            score+=dict[char]
        print(score)
    except KeyError:
        print("Ошибка ввода!")
    finally:    
        Py_Sem()
def Task21():
    """
    Напишите программу для печати всех уникальных
    значений в словаре.
    Input: [{"V": "S001"}, {"V": "S002"}, {"VI": "S001"},
    {"VI": "S005"}, {"VII": " S005 "}, {" V ":" S009 "}, {" VIII
    ":" S007 "}]
    Output: {'S005', 'S002', 'S007', 'S001', 'S009'}
    """
    print("ЗАДАЧА 21")
    dict = [{"V": "S001"}, 
            {"V": "S002"}, 
            {"VI": "S001"},
            {"VI": "S005"}, 
            {"VII": "S005"}, 
            {"V": "S009"}, 
            {"VIII":"S007"}]
    list = []
    for item in dict:
        for k in item: 
            if item[k] in list: continue
            list.append(item[k])
    print(list)
    Py_Sem()
def Task22():
    """
    Даны два неупорядоченных набора целых чисел (может быть, с
    повторениями). Выдать без повторений в порядке возрастания все те числа, которые
    встречаются в обоих наборах.
    Пользователь вводит 2 числа. n - кол-во элементов первого множества. m - кол-во
    элементов второго множества. Затем пользователь вводит сами элементы множеств.
    Input: 11 6
    2 4 6 8 10 12 10 8 6 4 2
    3 6 9 12 15 18
    Output: 6 12
    """
    print("ЗАДАЧА 22")
    task = input("Введите 2 числа: ")
    task = task.split()
    n = int(task[0]); m = int(task[1])
    list_1 = [0]*n; list_2 = [0]*m
    for i in range(n):
        list_1[i] = int(input(f"Введите {i+1} число 1 множества: "))
    for j in range(m):
        list_2[j] = int(input(f"Введите {j+1} число 2 множества: "))
    list_3 = []
    for item in list_1:
        if item in list_2 and item not in list_3:
            list_3.append(item)  
    print(*list_3)
    Py_Sem()
def Task23():
    """
    Дан массив, состоящий из целых чисел. Напишите
    программу, которая подсчитает количество
    элементов массива, больших предыдущего (элемента
    с предыдущим номером)
    Input: [0, -1, 5, 2, 3]
    Output: 2 (-1 < 5, 2 < 3)
    """
    print("ЗАДАЧА 23")
    from random import randint
    list_1 = [randint(-5, 5) for i in range(randint(5, 10))]
    print(list_1)
    list_2 = []
    total = 0
    for i in range(len(list_1)-1):
        if list_1[i] < list_1[i+1]:
            list_2.append(f"{list_1[i]} < {list_1[i+1]}")
            total+=1
    print(f"{total} {list_2}")
    Py_Sem()
def Task24():
    """
    В фермерском хозяйстве в Карелии выращивают чернику. Она растет на
    круглой грядке, причем кусты высажены только по окружности. Таким образом, у
    каждого куста есть ровно два соседних. Всего на грядке растет N кустов.
    Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них
    выросло различное число ягод – на i-ом кусте выросло a ягод.
    В этом фермерском хозяйстве внедрена система автоматического сбора черники.
    Эта система состоит из управляющего модуля и нескольких собирающих модулей.
    Собирающий модуль за один заход, находясь непосредственно перед некоторым
    кустом, собирает ягоды с этого куста и с двух соседних с ним.
    Напишите программу для нахождения максимального числа ягод, которое может
    собрать за один заход собирающий модуль, находясь перед некоторым кустом
    заданной во входном файле грядки.
    Input: 4 -> 1 2 3 4
    Output: 9
    """
    print("ЗАДАЧА 24")
    n = int(input("Введите количество кустов: "))
    bushes = [0]*n
    for i in range(n):
        bushes[i] = int(input(f"Введите количество ягод с {i+1} куста: "))
    max_berry_count = bushes[-1]+bushes[-2]+bushes[0]
    for i in range(n-1):
        berry_count = bushes[i]+bushes[i-1]+bushes[i+1]
        if berry_count > max_berry_count: max_berry_count = berry_count
    print(max_berry_count)
    Py_Sem()
def Task25():
    """
    Напишите программу, которая принимает на вход
    строку, и отслеживает, сколько раз каждый символ
    уже встречался. Количество повторов добавляется к
    символам с помощью постфикса формата _n.
    Input: a a a b c a a d c d d
    Output: a a_1 a_2 b c a_3 a_4 d c_1 d_1 d_2
    """
    print("ЗАДАЧА 25")
    string = input("Введите символы: ").split()
    count_dict = {}
    for char in range(len(string)):
        if string[char] in count_dict:
            count_dict[string[char]]+=1
            string[char] = f"{string[char]}_{count_dict[string[char]]}"
        else:
            count_dict[string[char]]=0
    print(string)
    Py_Sem() 
def Task26():
    """
    Напишите программу, которая на вход принимает
    два числа A и B, и возводит число А в целую степень B с
    помощью рекурсии.
    Input: 3 5 
    Output: 243
    """
    print("ЗАДАЧА 26")
    A = int(input("Введите число A: "))
    B = int(input("Введите число B: "))
    def get_pow(x, y):
        if y == 1: return x
        else: return x*get_pow(x, y-1)
    print(get_pow(A, B))
    Py_Sem()
def Task27():
    """
    Пользователь вводит текст(строка). Словом считается
    последовательность непробельных символов идущих
    подряд, слова разделены одним или большим числом
    пробелов. Определите, сколько различных слов
    содержится в этом тексте.
    Input: She sells sea shells on the sea shore The shells
    that she sells are sea shells I'm sure. So if she sells sea
    shells on the sea shore I'm sure that the shells are sea
    shore shells
    Output: 13
    """
    print("ЗАДАЧА 27")
    text = input("Введите текст: ").lower()
    symbols = [".", ",", ":", ";", "'"]
    for item in symbols:
        text.replace(item, " ")
    print(len(set(text.split())))
    Py_Sem()
def Task28():
    """
    Напишите рекурсивную функцию sum(a, b),
    возвращающую сумму двух целых неотрицательных чисел. Из
    всех арифметических операций допускаются только +1 и -1.
    Также нельзя использовать циклы.
    Input: 2 2
    Output: 4
    """
    print("ЗАДАЧА 28")
    A = int(input("Введите число A: "))
    B = int(input("Введите число B: "))
    def get_sum(x, y):
        return x if y == 0 else get_sum(x+1, y-1)
    print(get_sum(A, B))
    Py_Sem()
def Task29():
    """
    Задана последовательность
    неотрицательных целых чисел. Требуется определить
    значение наибольшего элемента
    последовательности, которая завершается первым
    встретившимся нулем (число 0 не входит в
    последовательность)
    """
    print("ЗАДАЧА 29")
    n = int(input()) 
    max_number = n 
    """
    Ошибка у Вани в "max_number = 1000" - введенные числа, скорее
    всего, не будут даже превышать заданную переменную; поэтому 
    лучше использовать значение n либо же значение -1, как у Пети.
    
    """
    while n != 0:
        """
        Ошибка у Пети (n<0) - первая же проверка цикла выведет false 
        """
        n = int(input())
        if max_number < n:
            """
            И снова ошибка у Вани: условие if max_number > n
            будет работать, если бы Ваня искал наименьшее число в
            последовательности, а не наоборот.
            """
            max_number = n
            """
            Снова ошибка у Пети - он перепутал местами n и max_number
            """
    print(max_number)
    """
    Еще одна ошибка у Пети: print(n) выведет последнее
    введенное число, а не наибольший элемент.
    Итого: 2 ошибки в коде у Вани и 3 ошибки у Пети.
    """ 
    Py_Sem()
def Task30():
    """
    Заполните массив элементами арифметической
    прогрессии. Её первый элемент, разность и количество
    элементов нужно ввести с клавиатуры. Формула для
    получения n-го члена прогрессии: a_n = a_1 + (n-1) * d.
    Каждое число вводится с новой строки.
    Input: 7 2 5
    Output: 7 9 11 13 15
    """
    print("ЗАДАЧА 30")
    a_1 = int(input("Введите первый элемент прогрессии: "))
    d = int(input("Введите разность элементов: "))
    n = int(input("Введите количество элементов: "))
    list = [a_1+(i-1)*d for i in range(1, n+1)]
    print(*list)
    Py_Sem()
def Task31():
    """
    Последовательностью Фибоначчи называется
    последовательность чисел a0, a1, ..., an, ..., где
    a0 = 0, a1 = 1, ak = ak-1 + ak-2 (k > 1).
    Требуется найти N-е число Фибоначчи
    Input: 7
    Output: 13
    """
    print("ЗАДАЧА 31")
    N = int(input("Введите число: "))
    def fib(a):
        return a if a==0 or a==1 else fib(a-1)+fib(a-2)
    print(fib(N))
    Py_Sem()
def Task32():
    """
    Определить индексы элементов массива (списка),
    значения которых принадлежат заданному диапазону (т.е. не
    меньше заданного минимума и не больше заданного
    максимума)
    Input: [-5, 9, 0, 3, -1, -2, 1, 4, -2, 10, 2, 0, -9, 8, 10, -9, 0, -5, -5, 7]
    5 15
    Output: [1, 9 13, 14, 19]
    """
    print("ЗАДАЧА 32")
    list_1 = [-5, 9, 0, 3, -1, -2, 1, 4, -2, 10, 2, 0, -9, 8, 10, -9, 0, -5, -5, 7]
    min = int(input("Введите заданный минимум: "))
    max = int(input("Введите заданный максимум: "))
    list_2 = [i for i in range(len(list_1)) if min<=list_1[i]<=max]
    print(list_2)
    Py_Sem()
def Task33():
    """
    Хакер Василий получил доступ к классному журналу и
    хочет заменить все свои минимальные оценки на
    максимальные. Напишите программу, которая
    заменяет оценки Василия, но наоборот: все
    максимальные – на минимальные.
    Input: 5 -> 1 3 3 3 4
    Output: 1 3 3 3 1
    """
    from random import randint
    print("ЗАДАЧА 33")
    N = int(input("Введите количество оценок: "))
    score = [randint(1, 5) for i in range(N)]
    print(score)
    new_score = []
    for item in score:
        if item == max(score): new_score.append(min(score))
        else: new_score.append(item)
    print(new_score)
    Py_Sem()
def Task34():
    """
    Винни-Пух попросил Вас посмотреть, есть ли в его стихах ритм. Поскольку
    разобраться в его кричалках не настолько просто, насколько легко он их придумывает, Вам
    стоит написать программу. Винни-Пух считает, что ритм есть, если число слогов (т.е. число
    гласных букв) в каждой фразе стихотворения одинаковое. Фраза может состоять из одного
    слова, если во фразе несколько слов, то они разделяются дефисами. Фразы отделяются друг
    от друга пробелами. Стихотворение Винни-Пух вбивает в программу с клавиатуры. В ответе
    напишите “Парам пам-пам”, если с ритмом все в порядке и “Пам парам”, если с ритмом все не
    в порядке.
    Input: пара-ра-рам рам-пам-папам па-ра-па-дам
    Output: Парам пам-пам
    """
    print("ЗАДАЧА 34")
    text = "пара-ра-рам рам-пам-папам па-ра-па-дам"
    text = text.split(" ")
    def syllable(text):
        syllable_count = []
        for line in text:
            sum_syllable = 0
            for char in line:
                if char in "уеыаоэяию": sum_syllable+=1
            syllable_count.append(sum_syllable)
        return syllable_count
    def rhythm_check(arr):
        for i in range(len(arr)-1):
            if arr[i]!=arr[i+1]: return False
        return True
    if rhythm_check(syllable(text)):
        print("Парам пам-пам")
    else:
        print("Пам парам")
    Py_Sem()
def Task35():
    """
    Напишите функцию, которая принимает одно число и
    проверяет, является ли оно простым
    Напоминание: Простое число - это число, которое
    имеет 2 делителя: 1 и n(само число)
    Input: 5
    Output: yes
    """
    print("ЗАДАЧА 35")
    N = int(input("Введите число: "))
    flag = True
    for i in range(2, N):
        if N%i==0:
            flag = False
            break
    print("yes") if flag else print("no")
    Py_Sem()
def Task36():
    """
    Напишите функцию print_operation_table(operation, num_rows=6, num_columns=6),
    которая принимает в качестве аргумента функцию, вычисляющую элемент по номеру строки и
    столбца. Аргументы num_rows и num_columns указывают число строк и столбцов таблицы,
    которые должны быть распечатаны. Нумерация строк и столбцов идет с единицы (подумайте,
    почему не с нуля). Примечание: бинарной операцией называется любая операция, у которой
    ровно два аргумента, как, например, у операции умножения.
    Input: print_operation_table(lambda x, y: x * y) 
    Output:
    1 2 3 4 5 6
    2 4 6 8 10 12
    3 6 9 12 15 18
    4 8 12 16 20 24
    5 10 15 20 25 30
    6 12 18 24 30 36 
    """
    print("ЗАДАЧА 36")
    num_rows = int(input("Введите количество строк: "))
    num_columns = int(input("Введите количество столбцов: "))
    def print_operation_table(operation,  row=num_rows, column=num_columns):
        matrix = [[[operation(x, y)] for y in range(1, column+1)] for x in range(1, row+1)]
        for i in range(row):
            for j in range(column):
                print(*matrix[i][j], end=" ")
            print()
    print_operation_table(lambda x, y: x*y)
    Py_Sem()
def Task37():
    """
    Дано натуральное число N и
    последовательность из N элементов.
    Требуется вывести эту последовательность в
    обратном порядке.
    Примечание. В программе запрещается
    объявлять массивы и использовать циклы
    (даже для ввода и вывода).
    Input: 2 -> 3 4
    Output: 4 3
    """
    print("ЗАДАЧА 37")
    N = int(input("Введите количество элементов N: "))
    def rec_output(x):
        if x == 0: return
        num = int(input("Введите число: "))
        rec_output(x-1)
        print(num, end=" ")
    rec_output(N)
    print()
    Py_Sem()
def Task38():
    """
    Создать телефонный справочник с
    возможностью импорта и экспорта данных в
    формате .txt. Фамилия, имя, отчество, номер
    телефона - данные, которые должны находиться
    в файле.
    1. Программа должна выводить данные
    2. Программа должна сохранять данные в
    текстовом файле
    3. Пользователь может ввести одну из
    характеристик для поиска определенной
    записи (Например имя или фамилию
    человека)
    4. Использование функций. Ваша программа
    не должна быть линейной
    Дополнить телефонный справочник возможностью изменения 
    и удаления данных. Пользователь также может ввести 
    имя или фамилию, и Вы должны реализовать функционал
    для изменения и удаления данных.
    """
    import os
    os.chdir(path=r'C:\Users\Acer Nitro 5\Desktop\G.I.T.\Python_Sem')
    print("ЗАДАЧА 38") 
    def PhoneBookMenu():
        print()
        print("Доступные функции: ")
        print("1. Вывод всех данных.")
        print("2. Поиск нужной записи.")
        print("3. Добавить новые данные.")
        print("4. Изменить имеющиеся данные.")
        print("5. Удалить имеющиеся данные.")
        task = input('Введите номер функции. Для закрытия программы введите "0": ')
        match task:
            case "0": print('Закрытие программы...')
            case "1": PrintPhoneBook()
            case "2": SearchNote()
            case "3": AddNewNote()
            case "4": ChangeNote()
            case "5": DeleteNote()
            case _: PhoneBookMenu()
    def ReadPhoneBook():
        dict=[]
        with open("phonebook.txt", encoding="utf-8") as data:
            for line in data:
                new_note = []
                line_list = line.split()
                new_note.append({"number":line_list[0], "name":line_list[1], "surname":line_list[2], "patronymic":line_list[3]})
                dict.append(new_note)
        return dict
    def PrintPhoneBook():
        data = ReadPhoneBook()
        for note in data:
            print(*note)                
        PhoneBookMenu()
    def SearchInBook():
        search = input("Введите номер, фамилию, имя или отчество, которое хотите найти: ")
        data = ReadPhoneBook()
        count = 0
        for note in data:
            for item in note:
                if search == item["number"] or search == item["name"] or search == item["surname"] or search == item["patronymic"]:
                    print("Запись найдена!")
                    return count
            count+=1
        return -1
    def SearchNote():
        data = ReadPhoneBook()
        res = SearchInBook()
        if(res==-1): print("Запись не найдена")
        else:
            print(*data[res])
        PhoneBookMenu()
    def RewritePhoneBook(data):
        with open("phonebook.txt", 'w', encoding="utf-8") as new_data:
            for i in range(len(data)):
                for j in range(len(data[i])):
                    new_data.write(data[i][j]["number"]+" ")
                    new_data.write(data[i][j]["name"]+" ")
                    new_data.write(data[i][j]["surname"]+" ")
                    new_data.write(data[i][j]["patronymic"]+" ")
                new_data.write('\n')
    def AddNewNote():
        data = ReadPhoneBook()
        new_note = []
        new_note.append({"number":input("Введите номер: "), "name":input("Введите имя: "), "surname":input("Введите фамилию: "), "patronymic":input("Введите отчество: ")})
        data.append(new_note)
        RewritePhoneBook(data)
        PhoneBookMenu()
    def ChangeNote():
        data = ReadPhoneBook()
        res = SearchInBook()
        if(res==-1): print("Запись не найдена")
        else:
            print(*data[res])
            data[res][0]["number"] = input("Введите новый номер: ")
            data[res][0]["name"] = input("Введите новое имя: ")
            data[res][0]["surname"] = input("Введите новую фамилию: ")
            data[res][0]["patronymic"] = input("Введите новое отчество: ")
        RewritePhoneBook(data)
        PhoneBookMenu()
    def DeleteNote():
        data = ReadPhoneBook()
        res = SearchInBook()
        if(res==-1): print("Запись не найдена")
        else:
            print(*data[res])
            delete = input("Для удаления записи нажмите '1': ")
            match delete:
                case "1":
                    data.pop(res)
                    RewritePhoneBook(data)
                    PhoneBookMenu()
                case _: PhoneBookMenu()
        PhoneBookMenu()
    PhoneBookMenu()
def Task39():
    """
    Даны два массива чисел. Требуется вывести те элементы
    первого массива (в том порядке, в каком они идут в первом
    массиве), которых нет во втором массиве. Пользователь вводит
    число N - количество элементов в первом массиве, затем N
    чисел - элементы массива. Затем число M - количество
    элементов во втором массиве. Затем элементы второго массива.
    Input: 
    7
    3 1 3 4 2 4 12
    6
    4 15 43 1 15 1
    Output: 3 3 2 12
    """
    print("ЗАДАЧА 39")
    N = int(input("Введите количество элементов первого массива: "))
    list_1 = [int(input(f"Введите {i+1} элемент первого массива: ")) for i in range(N)]
    M = int(input("Введите количество элементов второго массива: "))
    list_2 = [int(input(f"Введите {i+1} элемент второго массива: ")) for i in range(M)]
    list_3 = [item for item in list_1 if item not in list_2] 
    print(*list_1)
    print(*list_2)
    print(*list_3)
    Py_Sem()
def Task41():
    """
    Дан массив, состоящий из целых чисел. Напишите
    программу, которая в данном массиве определит
    количество элементов, у которых два соседних и, при
    этом, оба соседних элемента меньше данного. Сначала
    вводится число N — количество элементов в массиве
    Далее записаны N чисел — элементы массива. Массив
    состоит из целых чисел.
    Input: 
    5
    1 5 1 5 1
    Output: 2
    """
    print("ЗАДАЧА 41")
    N = int(input("Введите количество элементов массива: "))
    list_1 = [int(input(f"Введите {i+1} элемент массива: ")) for i in range(N)]
    count = 0
    for i in range(1, len(list_1)-1):
        if list_1[i-1] < list_1[i] > list_1[i+1]: count+=1
    print(count)
    Py_Sem()
def Task43():
    """
    Дан список чисел. Посчитайте, сколько в нем пар
    элементов, равных друг другу. Считается, что любые
    два элемента, равные друг другу образуют одну пару,
    которую необходимо посчитать. Вводится список
    чисел. Все числа списка находятся на разных
    строках.
    Input: 1 2 3 2 3
    Output: 2
    """
    print("ЗАДАЧА 43")
    N = int(input("Введите количество элементов массива: "))
    list = [int(input(f"Введите {i+1} элемент массива: ")) for i in range(N)]
    list_unique = []
    double_total = 0
    for item in list:
        for i in range(len(list_unique)): 
            if item == list_unique[i]: double_total+=1
        list_unique.append(item)
    print(double_total)
    Py_Sem()
def Task44():
    """
    В ячейке ниже представлен код генерирующий DataFrame, которая состоит всего из 1 столбца. 
    Ваша задача перевести его в one hot вид. Сможете ли вы это сделать без get_dummies?
    import random
    lst = ['robot'] * 10
    lst += ['human'] * 10
    random.shuffle(lst)
    data = pd.DataFrame({'whoAmI'lst})
    data.head()
    """
    print("ЗАДАЧА 44")
    import pandas as pd 
    import numpy as np 
    import random
    
    lst = ['robot'] * 10
    lst += ['human'] * 10
    random.shuffle(lst)
    data = pd.DataFrame({'whoAmI': lst})
    print(data)
    
    print('')

    data['tmp'] = 1
    data.set_index([data.index, 'whoAmI'], inplace=True)
    data = data.unstack(level=-1, fill_value = 0).astype(int)
    data.columns = data.columns.droplevel()
    data.columns.name = None
    print(data)
    Py_Sem()
def Task45():
    """
    Два различных натуральных числа n и m называются
    дружественными, если сумма делителей числа n
    (включая 1, но исключая само n) равна числу m и
    наоборот. Например, 220 и 284 – дружественные числа.
    По данному числу k выведите все пары дружественных
    чисел, каждое из которых не превосходит k. Программа
    получает на вход одно натуральное число k, не
    превосходящее 10**5. Программа должна вывести все
    пары дружественных чисел, каждое из которых не
    превосходит k. Пары необходимо выводить по одной в
    строке, разделяя пробелами. Каждая пара должна быть
    выведена только один раз (перестановка чисел новую
    пару не дает).
    Input: 300
    Output: 220 284
    """
    print("ЗАДАЧА 45")
    k = int(input("Введите число k: "))
    dict_num_sum = {}
    for i in range(2, k):
        sum = 0
        for j in range(1, i):
            if i%j==0: sum+=j
        dict_num_sum[i] = sum
        for amicable_num in dict_num_sum:
            if i == dict_num_sum[amicable_num] and dict_num_sum[i] == amicable_num and dict_num_sum[amicable_num]!=dict_num_sum[i]:
                print(dict_num_sum[i], dict_num_sum[amicable_num])
    Py_Sem()
def Task47():
    """
    У вас есть код, который вы не можете менять (так часто бывает, когда код в глубине
    программы используется множество раз и вы не хотите ничего сломать):
    transformation = <???>
    values = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29] # или любой другой список
    transormed_values = list(map(transformation, values))
    Единственный способ вашего взаимодействия с этим кодом - посредством задания
    функции transformation.
    Однако вы поняли, что для вашей текущей задачи вам не нужно никак преобразовывать
    список значений, а нужно получить его как есть.
    Напишите такое лямбда-выражение transformation, чтобы transformed_values получился
    копией values.
    INPUT:
        values = [1, 23, 42, ‘asdfg’]
        transformed_values = list(map(trasformation, values))
        if values == transformed_values:
            print(‘ok’)
        else:
            print(‘fail’)
    OUTPUT:
        ok
    """
    print("ЗАДАЧА 47")
    transformation = lambda x: x
    values = [1, 23, 42, "asdfg"]
    transformed_values = list(map(transformation, values))
    if values == transformed_values:
        print("ok")
    else:
        print("fail")
        Py_Sem()
def Task49():
    """
    Планеты вращаются вокруг звезд по эллиптическим орбитам.
    Назовем самой далекой планетой ту, орбита которой имеет
    самую большую площадь. Напишите функцию
    find_farthest_orbit(list_of_orbits), которая среди списка орбит
    планет найдет ту, по которой вращается самая далекая
    планета. Круговые орбиты не учитывайте: вы знаете, что у
    вашей звезды таких планет нет, зато искусственные спутники
    были были запущены на круговые орбиты. Результатом
    функции должен быть кортеж, содержащий длины полуосей
    эллипса орбиты самой далекой планеты. Каждая орбита
    представляет из себя кортеж из пары чисел - полуосей ее
    эллипса. Площадь эллипса вычисляется по формуле S = pi*a*b,
    где a и b - длины полуосей эллипса. При решении задачи
    используйте списочные выражения. Подсказка: проще всего
    будет найти эллипс в два шага: сначала вычислить самую
    большую площадь эллипса, а затем найти и сам эллипс,
    имеющий такую площадь. Гарантируется, что самая далекая
    планета ровно одна
    INPUT: 
        orbits = [(1, 3), (2.5, 10), (7, 2), (6, 6), (4, 3)]
        print(*find_farthest_orbit(orbits))
    OUTPUT: 
        2.5 10
    """
    print("ЗАДАЧА 49")
    # def find_farthest_orbit(array):
    #     max_S = 3.14 * array[0][0] * array[0][1]
    #     max_orbit = array[0]
    #     for x in range(len(array)):
    #         if 3.14 * array[x][0] * array[x][1] > max_S and array[x][0] != array[x][1]:
    #             max_S = 3.14 * array[x][0] * array[x][1]
    #             max_orbit = array[x]
    #     return max_orbit
    def find_farthest_orbit(arr):
        return max(arr, key=lambda x: (x[0]!=x[1])*x[0]*x[1]*3.14)
    orbits = [(1, 3), (2.5, 10), (7, 2), (6, 6), (4, 3)]
    print(*find_farthest_orbit(orbits))
    Py_Sem()
def Task51():
    """
    Напишите функцию same_by(characteristic, objects), которая
    проверяет, все ли объекты имеют одинаковое значение
    некоторой характеристики, и возвращают True, если это так.
    Если значение характеристики для разных объектов
    отличается - то False. Для пустого набора объектов, функция
    должна возвращать True. Аргумент characteristic - это
    функция, которая принимает объект и вычисляет его
    характеристику.
    Input:
        values = [0, 2, 10, 6] 
        if same_by(lambda x: x % 2, values):
            print(‘same’)
        else:
            print(‘different’)
    Output:
        same
    """
    print("ЗАДАЧА 51")
    def same_by(char, val):
        return True if len(val) == len(list(filter(char, val))) or len(list(filter(char, val))) == 0 else False
    values = [0, 2, 10, 6] 
    if same_by(lambda x: x % 2, values):
        print('same')
    else:
        print('different')
    Py_Sem()


Py_Sem()