CREATE TABLE Tours (
    tour_id INT PRIMARY KEY,
    tour_name VARCHAR(255) NOT NULL,
    tour_description TEXT NOT NULL,
    tour_type VARCHAR(255) NOT NULL,
    tour_route VARCHAR(255)
);


CREATE TABLE College (
    college_id INT PRIMARY KEY,
    college_name VARCHAR(255) NOT NULL,
    college_description TEXT NOT NULL
);

CREATE TABLE Department (
    department_id INT PRIMARY KEY,
    department_name VARCHAR(255) NOT NULL,
    department_description TEXT NOT NULL,
    college_id INT,
    FOREIGN KEY (college_id) REFERENCES College(college_id)
);

CREATE TABLE Points_of_Interest (
    poi_id INT PRIMARY KEY,
    poi_name VARCHAR(255) NOT NULL,
    poi_description TEXT NOT NULL,
    poi_image VARCHAR(255),
    poi_location VARCHAR(255),
    poi_qr_code VARCHAR(255),
    tour_id INT,
    FOREIGN KEY (tour_id) REFERENCES Tours(tour_id)
);

CREATE TABLE Users (
    user_id INT PRIMARY KEY,
    username VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL,
    password VARCHAR(255) NOT NULL,
    user_location VARCHAR(255)
);

CREATE TABLE Tour_Bookings (
    booking_id INT PRIMARY KEY,
    tour_id INT,
    user_id INT,
    booking_date DATE,
    booking_time TIME,
    FOREIGN KEY (tour_id) REFERENCES Tours(tour_id),
    FOREIGN KEY (user_id) REFERENCES Users(user_id)
);

CREATE TABLE Buildings (
    building_id INT PRIMARY KEY,
    building_name VARCHAR(255) NOT NULL,
    building_description TEXT NOT NULL,
    building_image VARCHAR(255),
    college_id INT,
    department_id INT,
    FOREIGN KEY (college_id) REFERENCES College(college_id),
    FOREIGN KEY (department_id) REFERENCES Department(department_id)
);
