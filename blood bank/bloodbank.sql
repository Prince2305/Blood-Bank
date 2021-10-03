-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 30, 2021 at 03:12 AM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bloodbank`
--

-- --------------------------------------------------------

--
-- Table structure for table `bloodstock`
--

CREATE TABLE `bloodstock` (
  `blood_Type` varchar(30) NOT NULL,
  `qty` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bloodstock`
--

INSERT INTO `bloodstock` (`blood_Type`, `qty`) VALUES
('O+', '1300'),
('O-', '100'),
('A+', '100'),
('A-', '100'),
('B+', '2800'),
('B-', '100'),
('AB+', '100'),
('AB-', '100');

-- --------------------------------------------------------

--
-- Table structure for table `bloodtransfer`
--

CREATE TABLE `bloodtransfer` (
  `pName` varchar(30) NOT NULL,
  `pGender` varchar(30) NOT NULL,
  `pbloodGroup` varchar(30) NOT NULL,
  `pqty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bloodtransfer`
--

INSERT INTO `bloodtransfer` (`pName`, `pGender`, `pbloodGroup`, `pqty`) VALUES
('nilesh', 'Male ', 'O+', 2000),
('nilesh', 'Male ', 'B+', 200),
('nilesh', 'Male ', 'B+', 200);

-- --------------------------------------------------------

--
-- Table structure for table `doner`
--

CREATE TABLE `doner` (
  `name` varchar(30) NOT NULL,
  `age` varchar(30) NOT NULL,
  `gender` varchar(30) NOT NULL,
  `phone` varchar(30) NOT NULL,
  `bloodGroup` varchar(30) NOT NULL,
  `adddress` varchar(30) NOT NULL,
  `qty` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `doner`
--

INSERT INTO `doner` (`name`, `age`, `gender`, `phone`, `bloodGroup`, `adddress`, `qty`) VALUES
('aditya', '20', 'Male ', '65432216', 'B+', 'sangli', '600'),
('vikas', '25', 'Male ', '98745216', 'B+', 'sangli', '2500');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `userName` varchar(30) NOT NULL,
  `pass` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`userName`, `pass`) VALUES
('nilesh', 'nilesh');

-- --------------------------------------------------------

--
-- Table structure for table `patient`
--

CREATE TABLE `patient` (
  `name` varchar(30) NOT NULL,
  `age` varchar(30) NOT NULL,
  `gender` varchar(30) NOT NULL,
  `phone` varchar(30) NOT NULL,
  `bloodGroup` varchar(30) NOT NULL,
  `address` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `patient`
--

INSERT INTO `patient` (`name`, `age`, `gender`, `phone`, `bloodGroup`, `address`) VALUES
('nilesh', '24', 'Male ', '9865213', 'AB+', 'sangli'),
('nishant', '24', 'Male ', '65487215', 'O+', 'sangli');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
