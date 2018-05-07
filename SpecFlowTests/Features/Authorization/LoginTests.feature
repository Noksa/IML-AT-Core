﻿# language: ru
Функционал: Попытка войти с неправильным логином либо паролем
@BadLogins
Структура сценария: Негативная проверка входа
       Когда открывается страница "Главная"
	   Тогда пользователь (запоминает значение) "Не верный логин или пароль!" "~Текст ошибки"
       И пользователь (нажимает кнопку) "Войти"
       Тогда открывается страница "Авторизация"
       И пользователь (заполняет поле) "Логин" значением "<login>"
       И пользователь (заполняет поле) "Пароль" значением "<password>"
       И пользователь (нажимает кнопку) "Войти"
       Тогда пользователь (проверяет значение элемента) "Текст ошибки" со значением "~Текст ошибки"
Примеры: 
| login        | password        |
| РусскийЛогин | РусскийПароль   |
| EnglishLogin | EnglishPassword |