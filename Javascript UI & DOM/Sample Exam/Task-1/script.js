function createCalendar(selector, events) {

    var calendar = document.querySelector(selector)
    var calendarItem = document.createElement('div');
    var calendarItemHeader = document.createElement('div');
    var calendarItemMain = document.createElement('div');
    calendarItem.setAttribute('class', 'calendar-item');
    calendarItemMain.setAttribute('class', 'calendar-item-main');
    calendarItemHeader.setAttribute('class', 'calendar-item-header');

    //Set style of calendar-item
    calendarItem.style.width = '170px';
    calendarItem.style.height = '170px';
    calendarItem.style.display = 'inline-block';
    calendarItem.style.border = '1px solid black';
    
    //Set style of calendar-item-header
    calendarItemHeader.style.width = '170px';
    calendarItemHeader.style.height = '20px';
    calendarItemHeader.style.borderBottom = '1px solid black';
    calendarItemHeader.style.background = '#B5B5B5';
    calendarItemHeader.style.textAlign = 'center';

    //Set style of calendar-item-main
    calendarItemMain.style.position = 'absolute';

    calendarItem.appendChild(calendarItemHeader);
    calendarItem.appendChild(calendarItemMain);

    var getDayName = function (day) {
        switch (day) {
            case 0: return 'Sun';
            case 1: return 'Mon';
            case 2: return 'Tue';
            case 3: return 'Wed';
            case 4: return 'Thu';
            case 5: return 'Fri';
            case 6: return 'Sat';
            default: break;

        }
    }

    //Draw calendar
    var NUMBER_OF_CALENDAR_DATES = 30;
    for (var i = 0; i < NUMBER_OF_CALENDAR_DATES; i++) {
        var newCalendarItem = calendarItem.cloneNode(true);
        var newDate = new Date(2014, 5, i + 1);
        var str = getDayName(newDate.getDay()) + ' ' + newDate.getDate() + ' June 2014 ';
        newCalendarItem.firstChild.textContent = str;

        newCalendarItem.addEventListener('click', function () {
            this.setAttribute('class', 'selected');
            this.firstChild.style.background = '#FFFFFF';
            
            for (var i = 1; i <= NUMBER_OF_CALENDAR_DATES; i++) {
                if (calendar.childNodes[i] != this) {

                    calendar.childNodes[i].removeAttribute('class', 'selected');
                    calendar.childNodes[i].firstChild.style.background = '#B5B5B5';
                }
            }
        });
        newCalendarItem.addEventListener('mouseover', function () {
            this.firstChild.style.background = '#737373';
        });
        newCalendarItem.addEventListener('mouseout', function () {

            function hasClass(element, cls) {
                return (' ' + element.className + ' ').indexOf(' ' + cls + ' ') > -1;
            }

            if (hasClass(this, 'selected')) {
                this.firstChild.style.background = '#FFFFFF';
            }
            else {
                this.firstChild.style.background = '#B5B5B5';
            }
        });
        calendar.appendChild(newCalendarItem);
    }

    //Extract events
    var calendarItems = calendar.childNodes;

    for (var i = 0; i < events.length; i++) {

        var currentEvent = events[i];
        var currentCalendarItem = calendarItems[parseInt(currentEvent['date'])];
        currentCalendarItem.lastChild.innerHTML = currentEvent['hour'] + ' ' + currentEvent['title'];
    }

}