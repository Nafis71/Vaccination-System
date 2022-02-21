-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 16, 2022 at 09:46 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `vaccination_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `center`
--

CREATE TABLE `center` (
  `center_id` int(100) NOT NULL,
  `center_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `center`
--

INSERT INTO `center` (`center_id`, `center_name`) VALUES
(1001, 'Kurmitola General Hospital'),
(1002, 'Bardhita pallabi Matrisadan');

-- --------------------------------------------------------

--
-- Table structure for table `registration`
--

CREATE TABLE `registration` (
  `reg_no` int(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `father_name` varchar(100) DEFAULT NULL,
  `mother_name` varchar(100) DEFAULT NULL,
  `father_nid` int(100) DEFAULT NULL,
  `mother_nid` int(100) DEFAULT NULL,
  `nid` int(100) DEFAULT NULL,
  `parent_num` int(100) DEFAULT NULL,
  `phone_num` int(100) DEFAULT NULL,
  `birth_certificate_num` int(100) DEFAULT NULL,
  `birth_date` varchar(100) DEFAULT NULL,
  `gender` varchar(100) NOT NULL,
  `indicator` int(100) NOT NULL,
  `center_name` varchar(100) NOT NULL,
  `doze_1` int(100) DEFAULT NULL,
  `doze_2` int(100) DEFAULT NULL,
  `reg_date` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `registration`
--

INSERT INTO `registration` (`reg_no`, `name`, `father_name`, `mother_name`, `father_nid`, `mother_nid`, `nid`, `parent_num`, `phone_num`, `birth_certificate_num`, `birth_date`, `gender`, `indicator`, `center_name`, `doze_1`, `doze_2`, `reg_date`) VALUES
(71, 'MD. Nafis Hasan Tonmoy', 'Mohammad Nur Islam', 'Nargis Akter', 452369875, 425698631, 0, 1304951029, 0, 2147483647, NULL, 'Male', 0, 'Bardhita pallabi Matrisadan', 0, 0, '2022-02-13 22:56:20'),
(72, 'Nehal', 'Nur Islam', 'Nargis Akter', 56982, 89682, NULL, 190635987, NULL, 0, NULL, 'Male', 1, 'Kurmitola General Hospital', NULL, NULL, '2022-02-16 14:41:29');

-- --------------------------------------------------------

--
-- Table structure for table `vaccinated`
--

CREATE TABLE `vaccinated` (
  `reg_no` int(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `nid` int(100) NOT NULL,
  `birth_certificate_num` int(100) NOT NULL,
  `birth_date` varchar(100) NOT NULL,
  `vaccine_name` varchar(100) NOT NULL,
  `doze1` int(100) NOT NULL,
  `doze2` int(100) NOT NULL,
  `doze1_date` varchar(100) NOT NULL,
  `doze2_date` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `vaccine_stock`
--

CREATE TABLE `vaccine_stock` (
  `center_id` int(100) NOT NULL,
  `vaccine_name` varchar(100) NOT NULL,
  `vaccine_quantity` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `vaccine_stock`
--

INSERT INTO `vaccine_stock` (`center_id`, `vaccine_name`, `vaccine_quantity`) VALUES
(1001, 'Sinopharm', 40),
(1001, 'Moderna', 20),
(1002, 'Moderna', 20),
(1002, 'Sinopharm', 28);

-- --------------------------------------------------------

--
-- Table structure for table `vac_adminlogin`
--

CREATE TABLE `vac_adminlogin` (
  `center_id` int(100) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `vac_adminlogin`
--

INSERT INTO `vac_adminlogin` (`center_id`, `password`) VALUES
(1002, '59d358403518f05b44f111aeda977837');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `center`
--
ALTER TABLE `center`
  ADD PRIMARY KEY (`center_id`);

--
-- Indexes for table `registration`
--
ALTER TABLE `registration`
  ADD PRIMARY KEY (`reg_no`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `registration`
--
ALTER TABLE `registration`
  MODIFY `reg_no` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=73;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
