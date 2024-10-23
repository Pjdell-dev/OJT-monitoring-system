-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Oct 23, 2024 at 08:15 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

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
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `EmployeeID` int(10) NOT NULL,
  `Last_Name` varchar(50) NOT NULL,
  `First_Name` varchar(50) NOT NULL,
  `Middle_Name` varchar(50) NOT NULL,
  `Department` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Account_Type` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`EmployeeID`, `Last_Name`, `First_Name`, `Middle_Name`, `Department`, `Email`, `Password`, `Account_Type`) VALUES
(1, 'David', 'Carlo', 'Cruz', 'Admin', 'ccdavid@tua.edu.ph', '123456', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `evalQuestions`
--

CREATE TABLE `evalQuestions` (
  `Eval1` varchar(255) NOT NULL,
  `Eval2` varchar(255) NOT NULL,
  `Eval3` varchar(255) NOT NULL,
  `Eval4` varchar(255) NOT NULL,
  `Eval5` varchar(255) NOT NULL,
  `Eval6` varchar(255) NOT NULL,
  `Eval7` varchar(255) NOT NULL,
  `Eval8` varchar(255) NOT NULL,
  `Eval9` varchar(255) NOT NULL,
  `Eval10` varchar(255) NOT NULL,
  `Eval11` varchar(255) NOT NULL,
  `Eval12` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `evalResults`
--

CREATE TABLE `evalResults` (
  `Student_Num` int(10) NOT NULL,
  `Eval1` int(5) NOT NULL,
  `Eval2` int(5) NOT NULL,
  `Eval3` int(5) NOT NULL,
  `Eval4` int(5) NOT NULL,
  `Eval5` int(5) NOT NULL,
  `Eval6` int(5) NOT NULL,
  `Eval7` int(5) NOT NULL,
  `Eval8` int(5) NOT NULL,
  `Eval9` int(5) NOT NULL,
  `Eval10` int(5) NOT NULL,
  `Eval11` int(5) NOT NULL,
  `Eval12` int(5) NOT NULL,
  `Comments` text NOT NULL,
  `EvaluatorID` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `studentAR`
--

CREATE TABLE `studentAR` (
  `Student_Num` int(10) NOT NULL,
  `Accomplishment_Report` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `Student_Num` int(10) NOT NULL,
  `Last_Name` varchar(50) NOT NULL,
  `First_Name` varchar(50) NOT NULL,
  `Middle_Name` varchar(50) NOT NULL,
  `Section` varchar(10) NOT NULL,
  `SupervisorID` int(10) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Account_Type` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`Student_Num`, `Last_Name`, `First_Name`, `Middle_Name`, `Section`, `SupervisorID`, `Email`, `Password`, `Account_Type`) VALUES
(2022300938, 'Nonato', 'Giancarlo', 'David', '3ITSE01', 2024000001, 'giancarlodnonato@tua.edu.ph', '123456', 'Student'),
(2022304192, 'Tordecilla', 'Joshua', 'Miguel', '3ITSE01', 2024000001, 'joshuamiguelmtordecilla@tua.edu.ph', '123456', 'Student');

-- --------------------------------------------------------

--
-- Table structure for table `supervisor`
--

CREATE TABLE `supervisor` (
  `SupervisorID` int(10) NOT NULL,
  `Last_Name` varchar(50) NOT NULL,
  `First_Name` varchar(50) NOT NULL,
  `Middle_Name` varchar(50) NOT NULL,
  `Company` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Account_Type` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `supervisor`
--

INSERT INTO `supervisor` (`SupervisorID`, `Last_Name`, `First_Name`, `Middle_Name`, `Company`, `Email`, `Password`, `Account_Type`) VALUES
(2024000001, 'Deloria', 'Peter', 'Elmido', 'Bangus Bros Corporation', 'peterjoshua@gmail.com', '123456', 'Supervisor');

-- --------------------------------------------------------

--
-- Table structure for table `timeLogs`
--

CREATE TABLE `timeLogs` (
  `Student_Num` int(10) NOT NULL,
  `Date` date NOT NULL,
  `Time_In` time NOT NULL,
  `Time_Out` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`EmployeeID`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`Student_Num`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- Indexes for table `supervisor`
--
ALTER TABLE `supervisor`
  ADD PRIMARY KEY (`SupervisorID`),
  ADD UNIQUE KEY `Email` (`Email`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
