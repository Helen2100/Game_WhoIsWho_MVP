# Game_WhoIsWho_MVP
**Название проекта**: Кто есть кто

**Команда**: Раскаты Грома АТ-01

**Формат системы**: desktop

**Цель проекта**: Создать образовательную игру по истории, которая поможет пользователям узнавать что-то новое о великих исторических личностях, лучше запоминать их имена и достижения.

**Описание**: 
Образовательная игра по истории представляет собой несколько режимов: Одиночный, Командный, Правда/Ложь. 
- В одиночном режиме перед пользователем представляется 2-3 факта и по ним пользователь должен угадать имя человека, которому принадлежит то или иное достижение, интересный факт из жизни. 
- В командном группа людей разбивается между собой на команды. Случайным образом выбирается кто из команд начинает первым. Выбирается один человек, который будет своей команде, в том числе и команде противников называть ряд фактов об известной личности, не называя его имени. У каждой команды есть 30 секунд на размышление. Тому, кто быстрее угадает, начисляется балл. Угадавшей команде передается устройство со следующим раундом. 
- Правда или ложь представляет собой интересный интерактив. Напоминает собой игру с Алисой в Яндекс Браузере "Верю/Не верю", но с существенным отличием. Вопросы относятся только к мировым личностям. Игроку показывается факт, и он должен дать правильный ответ, то есть правда ли относится факт к данной персоне или нет.

**Целевая аудитория**: Приложение предназначено для лиц старше 14 лет

**Основное преимущество**:

1.   Отсутствие прямого конкурента;
2.   Интересные факты о деятелях истории и культуры;
3.   Соревновательный метод обучения;
4.   Подходит для использования группы плюдей;

**Стек технологий**: Windows Forms, C#

**Сценарий использования**:

Пользователь заходит в игру. Выбирает один из режимов: Одиночный, Командный, Правда/Ложь.
- *Одиночный* В течение игры дает ответы на вопросы, узнает правильные ответы, получает результаты игры(счёт)
- *Командный* (по желанию игроков правила могут меняться) Происходит распределение по командам. Один из игроков называет несколько фактов об исторической личности. Угадавшей команде присуждается балл и передается телефон со следующим раундом. В конце выявляется победитель.
- *Правда/Ложь* Перед пользователем появляется один рандомный факт из истории. Пользователь угадываает - правда это или ложь. Узнает правильный ответ. Читает узнать более подробную информацию. Продолжает игру.

**Результат**: Мобильное приложение в плеймаркете.

**Основные требования**: Требования к продукту и к MVP

**На данном этапе были сформулированы следующие требования к нашему продукту**:
1. Легкость и простота в использовании.
2. Удобный интерфейс (включающий меню, настройки, обратную связь с разработчиком).
3. Подача исторических материалов и фактов в простом интересом формате.
4. Отсутствие сбоев и ошибок в работе программы.
5. Реализация несколько режимов игры – одиночный участник игры, турнир, правда - ложь.
6. Обеспечение поддержки нескольких платформ.

**Также на данном этапе были сформулированы следующие требования к MVP**: 
1. Легкость и простота в использовании;
2. Удобный интерфейс (включающий меню);
3. Подача исторических материалов и фактов в простом интересом формате;
4. Реализация одного режима игры (правда - ложь);

**Порядок установки**: Порядок установки еще не установлен.

**Основные требования к ПО для использования**: ANDROID

**Структура приложения**: 
1.  /bin/ - папка содержит двоичные файлы, которые являются фактическим исполняемым кодом для нашего продукта.
2.  /obj/ - папка содержит объектные или промежуточные файлы, которые представляют собой скомпилированные двоичные файлы,которые еще не были связаны.
3.  /Properties/ - папка содержит свойства проекта
4.  /Resources/ - папка содержит ресурсы нашего проекта(картинки, музыка, видео и т.д)
5.  /AuthorsPage.cs/ - программа, в которой прописаны команды для работы режима "Авторы"
6.  /AuthorsPage.Designer.cs/ - программа, в которой автоматически прописаны команды для работы режима "Авторы"(а именно дизайна данного режима)
7.  /AuthorsPage.resx/ - программа, в которой автоматически прописаны команды для работы режима "Авторы" (а именно ресурсов, которые данный режим использует)
8.  /Form1.cs/- программа, в которой прописаны команды для работы режима "Главное меню"
9.  /Form1.Designer.cs/ - программа, в которой автоматически прописаны команды для работы режима "Главное меню"(а именно дизайна данного режима)
10.  /Form1.resx/ - программа, в которой автоматически прописаны команды для работы режима "Авторы" (а именно ресурсов, которые данный режим использует)
11.  /Game_WholsWho_MVP. csproj/ - проект
12.  /Game_WholsWho_MVP.sIn/ - solution проекта
13.  /CommandModePage.cs/- программа, в которой прописаны команды для работы режима "Командный режим"
14.  /CommandModePage.Designer.cs/ - программа, в которой автоматически прописаны команды для работы режима "Командный режим"(а именно дизайна данного режима)
15.  /CommandModePage.resx/ - программа, в которой автоматически прописаны команды для работы режима "Командный режим" (а именно ресурсов, которые данный режим использует)
16.  /Program.cs/ - программа, в которой прописана главная точка входа для приложения.
17.  /questionsForTheCommandModePage/ - текстовый файл, в котором прописаны вопросы для командного режима
18.  /questionsForTheSingleModePage/ - текстовый файл, в котором прописаны вопросы для одиночного режима
19.  /questionsForTrueFalseModePage/ - текстовый файл, в котором прописаны вопросы для режима "Правда/ложь"
20.  /Resources.Designer.cs/ - программа, которая привсавивает некоторые атоматические свойства ресурсам
21.  /Resources.resx/ - программа, которая подключает фотографии, видео, звук и тд
22.  /RulePage.cs/- программа, в которой прописаны команды для работы страницы "Правила"
23.  /RulePage.Designer.cs/ - программа, в которой автоматически прописаны команды для работы страницы "Правила"
24.  /RulePage.resx/ - программа, в которой автоматически прописаны команды для работы страницы "Правила"
25.  /SingleModePage.cs/- программа, в которой прописаны команды для работы режима "Одиночный режим"
26.  /SingleModePage.Designer.cs/ - программа, в которой автоматически прописаны команды для работы режима "Одиночный режим"(а именно дизайна данного режима)
27.  /SingleModePage.resx/ - программа, в которой автоматически прописаны команды для работы режима "Одиночный режим" (а именно ресурсов, которые данный режим испо
28.  /StartPage.cs/- программа, в которой прописаны команды для работы страницы выбора режима
29.  /StartPage.Designer.cs/ - программа, в которой автоматически прописаны команды для работы страницы выбора режима
30.  /StartPage.resx/ - программа, в которой автоматически прописаны команды для работы страницы выбора режима
31.  /TrueFalseModePage.cs/- программа, в которой прописаны команды для работы режима "Правда/Ложь"
32.  /TrueFalseModePage.Designer.cs/ - программа, в которой автоматически прописаны команды для работы режима "Правда/Ложь"(а именно дизайна данного режима)
33.  /TrueFalseModePage.resx/ - программа, в которой автоматически прописаны команды для работы режима "Правда/Ложь" (а именно ресурсов, которые данный режим испо
