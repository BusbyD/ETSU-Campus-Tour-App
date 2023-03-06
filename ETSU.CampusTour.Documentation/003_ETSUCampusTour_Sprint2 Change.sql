USE ETSUCampusTours
UPDATE Buildings
SET building_description = 
    CASE building_id
        WHEN 1 THEN 'Primarily houses the College of Nursing at ETSU. The building is named after Roy S. Nicks who is an alumni of ETSU and a former Tennessee state senator.'
        WHEN 2 THEN 'Roger-Stout houses the ETSU Depart of Psychology. The building is named after two ETSU alumni, Robert Lee Rogers and Sam Stout, who were instrumental in establishing the ETSU Foundation.'
        WHEN 3 THEN 'Is the main library for the ETSU campus. It helps to provide many resources to students such as tutoring, helps assist students with research and provides many different types of sources to help students with their research.'
        WHEN 4 THEN 'The Culp center is a great place to relax on campus. It houses a food court , dining hall, post office, and the Bookstore.'
        WHEN 5 THEN 'The CPA is a gym for students. It has many activities to help students with promoting a healthy pursuit of becoming physically fit.'
        WHEN 6 THEN 'The minidome is ETSU�s sports complex. It houses a 4,000 seat arena, an Olympic-size swimming pool, gymnasium, weight and fitness rooms. The center houses both the basketball and volleyball teams at ETSU.'
        WHEN 7 THEN 'The Martin Center is performance and instructional spaces for students. It has three performance venues inside of it including a 1,200 seat venue hall the ETSU Foundation Grand Hall.'
        WHEN 8 THEN 'The Millennium Center hosts many different kinds of events for ETSU such as career fairs and conferences. The building features a large ballroom on the second floor and has an outdoor plaza for students to enjoy.'
    END
WHERE building_id BETWEEN 1 AND 8;

Delete from Buildings where building_id = 9;