"use strict"

var calendar; // ÊÚÑíİ ÇáãÊÛíÑ calendar İí äØÇŞ ÃæÓÚ

function fullCalendar() {
    // initialize the external events

    var containerEl = document.getElementById('external-events');
    if ($('#external-events').length > 0) {
        new FullCalendar.Draggable(containerEl, {
            itemSelector: '.external-event',
            eventData: function (eventEl) {
                return {
                    title: eventEl.innerText.trim()
                }
            }

        });
    }
    // ...


    // initialize the calendar
    var calendarEl = document.getElementById('calendar');
    calendar = new FullCalendar.Calendar(calendarEl, {
        headerToolbar: {
            left: 'prev,next Bu',
            center: 'title',
            right: 'Haf'
        },
        selectable: true,
        selectMirror: true,
        select: function (arg) {
            var title = prompt('Event Title:');
            if (title) {
                calendar.addEvent({
                    title: title,
                    start: arg.start,
                    end: arg.end,
                })
            }
            calendar.unselect()
        },
        editable: true,
        droppable: true, // this allows things to be dropped onto the calendar
        drop: function (arg) {
            // is the "remove after drop" checkbox checked?
            if (document.getElementById('drop-remove').checked) {
                // if so, remove the element from the "Draggable Events" list
                arg.draggedEl.parentNode.removeChild(arg.draggedEl);
            }
        },
        slotMinTime: '09:00:00', // ÊÍÏíÏ æŞÊ ÇáÈÏÁ Åáì ÇáÓÇÚÉ 9 ÕÈÇÍğÇ
        slotMaxTime: '24:00:00', // ÊÍÏíÏ æŞÊ ÇáÇäÊåÇÁ Åáì ãäÊÕİ Çááíá (12:00 ÕÈÇÍğÇ)
        allDaySlot: false, // ÅÒÇáÉ ÎíÇÑ "All Day"
        // ...
    });



    // ÊÍÏíË ÇáÊŞæíã áíÚÑÖ Çáíæã ÇáÍÇáí
    calendar.today();
    calendar.render();
}

jQuery(window).on('load', function () {
    setTimeout(function () {
        fullCalendar();
        // ÊÍÏíÏ ÇáÚÑÖ ÇáÇİÊÑÇÖí Åáì ÔåÑ
        calendar.changeView('timeGridWeek');


        // ÅÚÇÏÉ ÑÓã ÇáÊŞæíã áÊÍÏíË ÇáÚÑÖ
        calendar.render();
    }, 1000);
});
