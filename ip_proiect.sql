-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 24, 2021 at 08:44 PM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ip_proiect`
--

-- --------------------------------------------------------

--
-- Table structure for table `cos_cumparaturi`
--

CREATE TABLE `cos_cumparaturi` (
  `id` int(10) NOT NULL,
  `id_comanda` int(10) NOT NULL,
  `email` varchar(50) NOT NULL,
  `food_id` int(10) NOT NULL,
  `denumire` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cos_cumparaturi`
--

INSERT INTO `cos_cumparaturi` (`id`, `id_comanda`, `email`, `food_id`, `denumire`) VALUES
(96, 2, 'test1@yahoo.com', 6, 'Cascaval pane'),
(97, 2, 'test1@yahoo.com', 5, 'Ceafa de porc la tava'),
(98, 2, 'test1@yahoo.com', 7, 'Snitel din piept de pui'),
(99, 2, 'test1@yahoo.com', 13, 'Cartofi prajiti'),
(100, 2, 'test1@yahoo.com', 3, 'Branza cu smantana si mamaligu'),
(102, 2, 'test1@yahoo.com', 6, 'Cascaval pane'),
(111, 1, 'test1', 2, 'Supa cu galuste din gris'),
(112, 1, 'test1', 6, 'Cascaval pane');

-- --------------------------------------------------------

--
-- Table structure for table `food`
--

CREATE TABLE `food` (
  `id` int(11) NOT NULL,
  `Denumire produs` varchar(30) NOT NULL,
  `Pret` float NOT NULL,
  `Alergeni` varchar(50) NOT NULL,
  `Gramaj` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `food`
--

INSERT INTO `food` (`id`, `Denumire produs`, `Pret`, `Alergeni`, `Gramaj`) VALUES
(1, 'Ciorba taraneasca din carne de', 3.5, 'telina , gluten', '150g'),
(2, 'Supa cu galuste din gris', 1.5, 'telina,out,gluten', '350g'),
(3, 'Branza cu smantana si mamaligu', 3, 'lactoza', '200/220g'),
(4, 'Cotlet de porc la tava', 4.5, '-', '90g'),
(5, 'Ceafa de porc la tava', 4.5, '-', '90g'),
(6, 'Cascaval pane', 3.3, 'lactoza,gluten,ou', '100g'),
(7, 'Snitel din piept de pui', 2.5, 'gluten,ou', '80g'),
(8, 'Gratar din ceafa', 4.3, '-', '100g'),
(9, 'Piept de pui cu sos(intreg)', 3, 'gluten', '90/100g'),
(10, 'Gratar din piept de pui', 3, '-', '100g'),
(11, 'Piure din fulgi de cartofi', 1.2, '-', '200g'),
(12, 'Pilaf din orez', 1.15, '-', '200g'),
(13, 'Cartofi prajiti', 1.5, '-', '200g'),
(14, 'Paste cu carne de porc', 2.6, '-', '300g');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `email` varchar(100) NOT NULL,
  `parola` varchar(100) NOT NULL,
  `pin` varchar(10) DEFAULT NULL,
  `validare` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `email`, `parola`, `pin`, `validare`) VALUES
(1, 'test1@yahoo.com', 'abcd', '#@231', 1),
(2, 'test2@yahoo.com', 'a', '4231!#$', 0),
(3, 'test3@yahoo.com', 'a', 'VC324@\'', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cos_cumparaturi`
--
ALTER TABLE `cos_cumparaturi`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `food`
--
ALTER TABLE `food`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cos_cumparaturi`
--
ALTER TABLE `cos_cumparaturi`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=113;

--
-- AUTO_INCREMENT for table `food`
--
ALTER TABLE `food`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
