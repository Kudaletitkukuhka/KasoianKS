# KasoianKS

## Описание
KasoianKS — это программа, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры или использовать предустановленный.

## Как использовать

Введя в консоль команду `dotnet run` из папки `KasoianKS\Final Assignment`, пользователь увидет следующее сообщение:

     Нажмите Enter, если хотите ввести массив вручную.
     Введите Y и нажмите Enter, если хотите использовать встроенный массив.

+ **Использовать предустановленный массив строк**\
После ввода Y в консоли и нажатия Enter программа выполняется с использованием предустановленного массива defArray. В консоли будет произведен вывод первоначального массива, а также нового массива, в котором есть только элементы длиной не более 3 символов.

+ **Ввести массив вручную**\
После нажатия Enter, пользователь вводит кол-во элементов, которые он хочет добавить в массив. а затем построчно вводит каждый из элементов.

В конце программа выдаст массив, который будет содержать только элементы длиной до 3 символов включительно.

## Примеры результата работы программы

     Нажмите Enter, если хотите ввести массив вручную.
     Введите Y и нажмите Enter, если хотите использовать встроенный массив.

     Количество элементов в вашем массиве:   5
     ывывывы
     dksk
     Ik
     2828k
     ss
     Вы ввели массив: {ывывывы, dksk, Ik, 2828k, ss}
     Массив с элементами длиной не больше 3 символов: {Ik, ss}