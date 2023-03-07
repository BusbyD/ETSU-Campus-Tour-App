
INSERT INTO Tours (tour_id, tour_name, tour_description, tour_type, tour_route)
VALUES (1, 'Standard Tour', 'A tour of all the main buildings on campus', 'standard', 'Building 1, Building 2, Building 3, Building 4'),
       (2, 'College of Arts and Sciences Tour', 'A tour of the buildings and departments in the College of Arts and Sciences', 'college-specific', 'Building 5, Building 6, Building 7'),
       (3, 'Department of Computer Science Tour', 'A tour of the Computer Science department', 'department-specific', 'Building 8'),
       (4, 'History and Art Tour', 'A tour of the historical and art-related buildings and points of interest on campus', 'non-academic', 'Building 9, Building 10, Point of Interest 1, Point of Interest 2');

INSERT INTO College (college_id, college_name, college_description)
VALUES (1, 'College of Arts and Sciences', 'This is the College of Arts and Sciences'),
(2, 'College of Business and Technology', 'This is the College of Business and Technology'),
(3, 'College of Clinical and Rehabilitative Health Sciences', 'This is the College of Clinical and Rehabilitative Health Sciences'),
(4, 'Clemmer College', 'This is the Clemmer College'),
(5, 'James H. Quillen College of Medicine', 'This is the James H. Quillen College of Medicine'),
(6, 'College of Nursing', 'This is the College of Nursing'),
(7, 'College of Pharmacy', 'This is the College of Pharmacy'),
(8, 'College of Public Health', 'This is the College of Public Health'),
(9, 'Honors College', 'This is the Honors College');

INSERT INTO Department (department_id, department_name, department_description, college_id)
VALUES (1, 'Appalachian Studies', 'This is the Appalachian Studies department', 1),
(2, 'Art and Design', 'This is the Art and Design department', 1),
(3, 'Biological Sciences', 'This is the Biological Sciences department', 1),
(4, 'Bluegrass, Old-Time, and Country Music Studies', 'This is the Bluegrass, Old-Time, and Country Music Studies department', 1),
(5, 'Chemistry', 'This is the Chemistry department', 1),
(6, 'Communication and Performance', 'This is the Communication and Performance department', 1),
(7, 'Criminal Justice and Criminology', 'This is the Criminal Justice and Criminology department', 1),
(8, 'Geosciences', 'This is the Geosciences department', 1),
(9, 'History', 'This is the History department', 1),
(10, 'Literature and Language', 'This is the Literature and Language department', 1),
(11, 'Mathematics and Statistics', 'This is the Mathematics and Statistics department', 1),
(12, 'Media and Communication', 'This is the Media and Communication department', 1),
(13, 'Music', 'This is the Music department', 1),
(14, 'Philosophy and Humanities', 'This is the Philosophy and Humanities department', 1),
(15, 'Physics and Astronomy', 'This is the Physics and Astronomy department', 1),
(16, 'Political Science, International Affairs and Public Admin.', 'This is the Political Science, International Affairs and Public Admin. department', 1),
(17, 'Psychology', 'This is the Psychology department', 1),
(18, 'Sociology and Anthropology', 'This is the Sociology and Anthropology department', 1),
(19, 'Theatre and Dance', 'This is the Theatre and Dance department', 1),
(20, 'Accountancy', 'This is the Accountancy department', 2),
(21, 'Computing', 'This is the Computing department', 2),
(22, 'Digital Media', 'This is the Digital Media department', 2),
(23, 'Economics and Finance', 'This is the Economics and Finance department', 2),
(24, 'Engineering, Engineering Technology, and Surveying', 'This is the Engineering, Engineering Technology, and Surveying department', 2),
(25, 'Management and Marketing', 'This is the Management and Marketing department', 2),
(26, 'Military Science', 'This is the Military Science department', 2),
(27, 'Dental Hygiene', 'This is the Dental Hygiene department', 3),
(28, 'Nutrition', 'This is the Nutrition department', 3),
(29, 'Audiology and Speech-Language Pathology', 'This is the Audiology and Speech-Language Pathology department', 3),
(30, 'Rehabilitative Health Sciences (Undergraduate)', 'This is the Rehabilitative Health Sciences department for Undergraduate', 3),
(31, 'Social Work (Undergraduate and Graduate)', 'This is the Social Work department for Undergraduate and Graduate', 3),
(32, 'Physical Therapy', 'This is the Physical Therapy department', 3),
(33, 'Occupational Therapy', 'This is the Occupational Therapy department', 3),
(34, 'Prosthetics and Orthodontics', 'This is the Prosthetics and Orthodontics department', 3),
(35, 'Allied Health Major (Allied Health Leadership Concentration)', 'This is the Allied Health Major department with Allied Health Leadership Concentration', 3),
(36, 'Respiratory Therapy', 'This is the Respiratory Therapy department', 3),
(37, 'Radiologic Science', 'This is the Radiologic Science department', 3),
(38, 'Counseling & Human Services', 'This is the Counseling & Human Services department', 4),
(39, 'Curriculum & Instruction', 'This is the Curriculum & Instruction department', 4),
(40, 'Early Childhood Education', 'This is the Early Childhood Education department', 4),
(41, 'Educational Foundations & Special Education', 'This is the Educational Foundations & Special Education department', 4),
(42, 'Educational Leadership & Policy Analysis', 'This is the Educational Leadership & Policy Analysis department', 4),
(43, 'Sport, Exercise, Recreation, and Kinesiology', 'This is the Sport, Exercise, Recreation, and Kinesiology department', 4),
(44, 'Biomedical Graduate Program', 'Graduate program focused on Biomedical Sciences', 5),
(45, 'Department of Biomedical Sciences', 'Department offering courses and research in Biomedical Sciences', 5),
(46, 'Department of Medical Education', 'Department providing medical education and training', 5),
(47, 'Clinical Departments', 'Department that deals with patients, diagnoses, treatments and management', 5),
(48, 'Family Medicine', 'Department specializing in Family Medicine', 5),
(49, 'Internal Medicine', 'Department specializing in Internal Medicine', 5),
(50, 'Obstetrics and Gynecology', 'Department specializing in Obstetrics and Gynecology', 5),
(51, 'Pathology', 'Department specializing in Pathology', 5),
(52, 'Pediatrics', 'Department specializing in Pediatrics', 5),
(53, 'Psychiatry and Behavioral Sciences', 'Department specializing in Psychiatry and Behavioral Sciences', 5),
(54, 'Surgery', 'Department specializing in Surgery', 5);


INSERT INTO Points_of_Interest (poi_id, poi_name, poi_description, poi_image, poi_location, poi_qr_code, tour_id)
VALUES (1, 'Point of Interest 1', 'This is Building 1', 'poi1.jpg', 'Location 1', 'QR Code 1', 1),
       (2, 'Point of Interest 2', 'This is Building 2', 'poi2.jpg', 'Location 2', 'QR Code 2', 1),
	   (3, 'Point of Interest 3', 'This is Building 3', 'poi2.jpg', 'Location 3', 'QR Code 3', 1),
	   (4, 'Point of Interest 4', 'This is Building 4', 'poi2.jpg', 'Location 4', 'QR Code 4', 1),
	   (5, 'Point of Interest 5', 'This is Building 5', 'poi2.jpg', 'Location 5', 'QR Code 5', 1),
	   (6, 'Point of Interest 6', 'This is Building 6', 'poi2.jpg', 'Location 6', 'QR Code 6', 1),
	   (7, 'Point of Interest 7', 'This is the ETSU Flagpole', 'poi2.jpg', 'Location 7', 'QR Code 7', 2),
	   (8, 'Point of Interest 8', 'This is Building 7', 'poi2.jpg', 'Location 8', 'QR Code 8', 1),
	   (9, 'Point of Interest 9', 'This is Building 8', 'poi2.jpg', 'Location 9', 'QR Code 9', 1),
	   (10, 'Point of Interest 10', 'This is Building 9', 'poi2.jpg', 'Location 10', 'QR Code 10', 1);

INSERT INTO Users (user_id, username, email, password, user_location)
VALUES (1, 'user1', 'user1@example.com', 'password1', 'location1'),
       (2, 'user2', 'user2@example.com', 'password2', 'location2'),
       (3, 'user3', 'user3@example.com', 'password3', 'location3'),
       (4, 'user4', 'user4@example.com', 'password4', 'location4');

INSERT INTO Buildings (building_id, building_name, building_description, building_image, college_id, department_id)
VALUES (1, 'Nicks Hall', 'This is a description of Building 1', 'building1.jpg', 1, 1),
       (2, 'Rogers-Stout Hall', 'This is a description of Building 2', 'building2.jpg', 2, 1),
       (3, 'Charles C. Sherrod Library', 'This is a description of Building 3', 'building3.jpg', 1, 1),
       (4, 'The Culp Center', 'This is a description of Building 4', 'building4.jpg', 2, 1),
	   (5, 'Basler Center for Physical Activity', 'This is a description of Building 5', 'building5.jpg', 1, 2),
       (6, 'Ballad Health Athletic Center', 'This is a description of Building 6', 'building6.jpg', 2, 2),
       (7, 'Martin Center for the Arts', 'This is a description of Building 7', 'building7.jpg', 2, 2),
       (8, 'Millenium Center', 'This is a description of Building 8', 'building8.jpg', 2, 2),
       (9, 'Roys Nicks Hall', 'This is a description of Building 9', 'building9.jpg', 2, 2);

