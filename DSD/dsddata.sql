-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 28, 2018 at 01:03 PM
-- Server version: 10.1.26-MariaDB
-- PHP Version: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dsddata`
--

-- --------------------------------------------------------

--
-- Table structure for table `center`
--

CREATE TABLE `center` (
  `chek` char(2) NOT NULL,
  `year` char(8) NOT NULL,
  `Month` char(4) NOT NULL,
  `subjec` char(40) NOT NULL,
  `teacher` char(60) NOT NULL,
  `NoOfStudent` char(30) NOT NULL,
  `amount` char(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `class`
--

CREATE TABLE `class` (
  `subject` varchar(20) NOT NULL,
  `year` varchar(20) NOT NULL,
  `teacher` char(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `classadd`
--

CREATE TABLE `classadd` (
  `year` char(8) NOT NULL,
  `subjec` char(30) NOT NULL,
  `name` char(30) NOT NULL,
  `phoneNumber` char(10) NOT NULL,
  `addres` char(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `dsdstudentdetails`
--

CREATE TABLE `dsdstudentdetails` (
  `id` varchar(10) NOT NULL,
  `name` char(50) NOT NULL,
  `studentNumber` int(20) NOT NULL,
  `addres` varchar(50) NOT NULL,
  `phoneNumber` varchar(10) NOT NULL,
  `date` date NOT NULL,
  `batch` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `username` char(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `Value` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`username`, `password`, `Value`) VALUES
('Admin', '12345678', 1);

-- --------------------------------------------------------

--
-- Table structure for table `marks`
--

CREATE TABLE `marks` (
  `studentNumber` int(30) NOT NULL,
  `Name` char(50) NOT NULL,
  `subject` varchar(20) NOT NULL,
  `1` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `dsdstudentdetails`
--
ALTER TABLE `dsdstudentdetails`
  ADD PRIMARY KEY (`studentNumber`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `marks`
--
ALTER TABLE `marks`
  ADD PRIMARY KEY (`studentNumber`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
