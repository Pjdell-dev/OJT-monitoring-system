-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 10, 2024 at 04:22 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tua_ojt_monitoring`
--

-- --------------------------------------------------------

--
-- Table structure for table `accomplishment_reports`
--

CREATE TABLE `accomplishment_reports` (
  `report_id` int(11) NOT NULL,
  `student_id` int(11) NOT NULL,
  `report_date` date NOT NULL,
  `content` text NOT NULL,
  `comments` text DEFAULT NULL,
  `submission_status` enum('Submitted','Not Submitted','Late') NOT NULL DEFAULT 'Not Submitted'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `accomplishment_reports`
--

INSERT INTO `accomplishment_reports` (`report_id`, `student_id`, `report_date`, `content`, `comments`, `submission_status`) VALUES
(2, 2022304192, '2024-10-23', '', '', 'Not Submitted'),
(3, 101, '2024-10-10', 'did something', NULL, 'Submitted'),
(4, 101, '2024-10-17', 'i', NULL, 'Submitted'),
(5, 102345, '2024-10-17', 'Worked on system documentation.', NULL, 'Submitted'),
(6, 103, '2024-10-10', '', NULL, 'Not Submitted'),
(7, 103, '2024-10-17', 'did something', NULL, 'Submitted'),
(8, 104, '2024-10-10', 'did something', NULL, 'Submitted'),
(9, 104, '2024-10-17', 'did something', NULL, 'Submitted'),
(10, 2020392149, '2024-10-17', '', NULL, 'Not Submitted'),
(11, 10634522, '2024-10-17', '', NULL, 'Not Submitted');

-- --------------------------------------------------------

--
-- Table structure for table `administrators`
--

CREATE TABLE `administrators` (
  `admin_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `contact_number` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `administrators`
--

INSERT INTO `administrators` (`admin_id`, `user_id`, `last_name`, `first_name`, `contact_number`) VALUES
(328472894, 1, 'Minh', 'Add', '09237498729');

-- --------------------------------------------------------

--
-- Table structure for table `criteria`
--

CREATE TABLE `criteria` (
  `criteria_id` int(11) NOT NULL,
  `criteria_name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `criteria`
--

INSERT INTO `criteria` (`criteria_id`, `criteria_name`) VALUES
(1, 'Accurate and Detects error'),
(2, 'Performs duties as expected'),
(3, 'Knows the job well'),
(4, 'Regular and punctual'),
(5, 'Nice');

-- --------------------------------------------------------

--
-- Table structure for table `evaluations`
--

CREATE TABLE `evaluations` (
  `evaluation_id` int(11) NOT NULL,
  `student_id` int(11) NOT NULL,
  `supervisor_id` int(11) NOT NULL,
  `evaluation_date` date NOT NULL,
  `comments` text DEFAULT NULL,
  `status` enum('Submitted','Not Submitted') NOT NULL DEFAULT 'Not Submitted'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `evaluations`
--

INSERT INTO `evaluations` (`evaluation_id`, `student_id`, `supervisor_id`, `evaluation_date`, `comments`, `status`) VALUES
(9, 101, 1069, '2024-10-24', NULL, 'Not Submitted'),
(10, 101, 1069, '2024-10-25', NULL, 'Not Submitted');

-- --------------------------------------------------------

--
-- Table structure for table `evaluation_scores`
--

CREATE TABLE `evaluation_scores` (
  `score_id` int(11) NOT NULL,
  `evaluation_id` int(11) NOT NULL,
  `criteria_id` int(11) NOT NULL,
  `score` tinyint(1) NOT NULL CHECK (`score` between 1 and 5)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `evaluation_scores`
--

INSERT INTO `evaluation_scores` (`score_id`, `evaluation_id`, `criteria_id`, `score`) VALUES
(2, 9, 1, 1),
(3, 9, 2, 2),
(4, 9, 3, 3),
(5, 9, 4, 4),
(6, 9, 5, 5),
(7, 10, 1, 1),
(8, 10, 2, 2),
(9, 10, 3, 3),
(10, 10, 4, 4),
(11, 10, 5, 5);

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `student_id` int(11) NOT NULL,
  `last_name` varchar(45) NOT NULL,
  `first_name` varchar(45) NOT NULL,
  `contact_number` varchar(11) NOT NULL,
  `status` enum('Active','Completed','Withdrawn') DEFAULT NULL,
  `user_id` int(11) NOT NULL,
  `supervisor_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`student_id`, `last_name`, `first_name`, `contact_number`, `status`, `user_id`, `supervisor_id`) VALUES
(101, 'Brown', 'Alice', '09171234567', 'Active', 10, 1069),
(103, 'Greens', 'Charlie', '09172349876', 'Active', 12, 1069),
(104, 'White', 'Danas', '09179874321', 'Completed', 13, 2),
(102345, 'bou', 'Bobby', '092345123', 'Active', 11, 1069),
(10634522, 'Furt', 'Frank', '09171234890', 'Withdrawn', 15, 3),
(2020392149, 'Yes', 'Eve', '09176548921', 'Active', 14, 2),
(2022300938, 'Nonato', 'Giancarlo', '09279142603', NULL, 2, 2),
(2022304192, 'Tordecilla', 'Joshua', '09458762518', 'Active', 4, 1069);

-- --------------------------------------------------------

--
-- Table structure for table `supervisors`
--

CREATE TABLE `supervisors` (
  `supervisor_id` int(11) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `contact_number` varchar(11) NOT NULL,
  `company` varchar(100) NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `supervisors`
--

INSERT INTO `supervisors` (`supervisor_id`, `last_name`, `first_name`, `contact_number`, `company`, `user_id`) VALUES
(2, 'Smith', 'Anna', '09456072334', 'TechCorp', 7),
(3, 'Johnson', 'Peter', '091002345', 'SoftSolutions', 8),
(1069, 'Visor', 'Suuupeerrrr', '09249452145', 'company', 5),
(2343453, 'This', 'Delete', '09090909', 'Company', 23);

-- --------------------------------------------------------

--
-- Table structure for table `time_logs`
--

CREATE TABLE `time_logs` (
  `timelogs_id` int(10) UNSIGNED NOT NULL,
  `student_id` int(11) NOT NULL,
  `date` date DEFAULT NULL,
  `status` enum('Present','Absent','Excused') DEFAULT NULL,
  `time_in` time DEFAULT NULL,
  `time_out` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `time_logs`
--

INSERT INTO `time_logs` (`timelogs_id`, `student_id`, `date`, `status`, `time_in`, `time_out`) VALUES
(3, 101, '2024-10-21', 'Present', '08:00:00', '17:00:00'),
(4, 102345, '2024-10-21', 'Present', '08:30:00', '16:30:00'),
(5, 103, '2024-10-21', 'Absent', NULL, NULL),
(6, 104, '2024-10-21', 'Present', '09:00:00', '18:00:00'),
(7, 2020392149, '2024-10-21', 'Present', '08:00:00', '17:00:00'),
(8, 10634522, '2024-10-21', 'Absent', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `user_email` varchar(50) NOT NULL,
  `account_type` enum('admin','student','supervisor') NOT NULL,
  `user_password` varchar(255) NOT NULL,
  `last_login` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `user_email`, `account_type`, `user_password`, `last_login`) VALUES
(1, 'admin@gmail.com', 'admin', '12345', NULL),
(2, 'giancarlodnonato@tua.edu.ph', 'student', '123456', NULL),
(4, 'joshuamiguelmtordecilla@tua.edu.ph', 'student', '123', NULL),
(5, 'supervisor@gmail.com', 'supervisor', '123', NULL),
(7, 'supervisor921@gmail.com', 'supervisor', 'pass123', NULL),
(8, 'supervisor2@gmail.com', 'supervisor', 'pass123', NULL),
(10, 'student1@gmail.com', 'student', 'student123', NULL),
(11, 'student2@gmail.com', 'student', 'student123', NULL),
(12, 'student3@gmail.com', 'student', 'student123', NULL),
(13, 'student4@gmail.com', 'student', 'student123', NULL),
(14, 'student5@gmail.com', 'student', 'student123', NULL),
(15, 'student6@gmail.com', 'student', 'student123', NULL),
(23, 'verusclues@gmail.com', 'supervisor', '123', NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accomplishment_reports`
--
ALTER TABLE `accomplishment_reports`
  ADD PRIMARY KEY (`report_id`),
  ADD KEY `accomplishment_reports_ibfk_1` (`student_id`);

--
-- Indexes for table `administrators`
--
ALTER TABLE `administrators`
  ADD PRIMARY KEY (`admin_id`),
  ADD UNIQUE KEY `admin_id_UNIQUE` (`admin_id`),
  ADD KEY `fk_administrators_user_id_idx` (`user_id`);

--
-- Indexes for table `criteria`
--
ALTER TABLE `criteria`
  ADD PRIMARY KEY (`criteria_id`);

--
-- Indexes for table `evaluations`
--
ALTER TABLE `evaluations`
  ADD PRIMARY KEY (`evaluation_id`),
  ADD KEY `evaluations_ibfk_1` (`student_id`),
  ADD KEY `evaluations_ibfk_2` (`supervisor_id`);

--
-- Indexes for table `evaluation_scores`
--
ALTER TABLE `evaluation_scores`
  ADD PRIMARY KEY (`score_id`),
  ADD KEY `evaluation_scores_ibfk_1` (`evaluation_id`),
  ADD KEY `evaluation_scores_ibfk_2` (`criteria_id`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`student_id`),
  ADD UNIQUE KEY `student_number_UNIQUE` (`student_id`),
  ADD KEY `fk_students_user_id_idx` (`user_id`),
  ADD KEY `fk_students_supervisor_id` (`supervisor_id`);

--
-- Indexes for table `supervisors`
--
ALTER TABLE `supervisors`
  ADD PRIMARY KEY (`supervisor_id`),
  ADD UNIQUE KEY `supervisor_id_UNIQUE` (`supervisor_id`),
  ADD KEY `fk_supervisors_user_id_idx` (`user_id`);

--
-- Indexes for table `time_logs`
--
ALTER TABLE `time_logs`
  ADD PRIMARY KEY (`timelogs_id`),
  ADD UNIQUE KEY `idattendance_UNIQUE` (`timelogs_id`),
  ADD KEY `fk_time_logs_student_number_idx` (`student_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `user_id_UNIQUE` (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accomplishment_reports`
--
ALTER TABLE `accomplishment_reports`
  MODIFY `report_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `administrators`
--
ALTER TABLE `administrators`
  MODIFY `admin_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=328472895;

--
-- AUTO_INCREMENT for table `criteria`
--
ALTER TABLE `criteria`
  MODIFY `criteria_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `evaluations`
--
ALTER TABLE `evaluations`
  MODIFY `evaluation_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `evaluation_scores`
--
ALTER TABLE `evaluation_scores`
  MODIFY `score_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `time_logs`
--
ALTER TABLE `time_logs`
  MODIFY `timelogs_id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `accomplishment_reports`
--
ALTER TABLE `accomplishment_reports`
  ADD CONSTRAINT `accomplishment_reports_ibfk_1` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `administrators`
--
ALTER TABLE `administrators`
  ADD CONSTRAINT `fk_administrators_user_id` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `evaluations`
--
ALTER TABLE `evaluations`
  ADD CONSTRAINT `evaluations_ibfk_1` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `evaluations_ibfk_2` FOREIGN KEY (`supervisor_id`) REFERENCES `supervisors` (`supervisor_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `evaluation_scores`
--
ALTER TABLE `evaluation_scores`
  ADD CONSTRAINT `evaluation_scores_ibfk_1` FOREIGN KEY (`evaluation_id`) REFERENCES `evaluations` (`evaluation_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `evaluation_scores_ibfk_2` FOREIGN KEY (`criteria_id`) REFERENCES `criteria` (`criteria_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `students`
--
ALTER TABLE `students`
  ADD CONSTRAINT `fk_students_supervisor_id` FOREIGN KEY (`supervisor_id`) REFERENCES `supervisors` (`supervisor_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_students_user_id` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `supervisors`
--
ALTER TABLE `supervisors`
  ADD CONSTRAINT `fk_supervisors_user_id` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `time_logs`
--
ALTER TABLE `time_logs`
  ADD CONSTRAINT `fk_time_logs_student_number` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
