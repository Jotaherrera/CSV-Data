-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3308
-- Generation Time: Nov 06, 2022 at 02:55 AM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbcsvdata`
--

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `ISBN` varchar(10) NOT NULL,
  `title` varchar(98) NOT NULL,
  `publicationYear` year(4) NOT NULL,
  `publisher` varchar(24) NOT NULL,
  `imgURL` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`ISBN`, `title`, `publicationYear`, `publisher`, `imgURL`) VALUES
('0002005018', 'Clara Callan', 2001, 'HarperFlamingo Canada', 'http://images.amazon.com/images/P/0002005018.01.THUMBZZZ.jpg'),
('0060973129', 'Decision in Normandy', 1991, 'HarperPerennial', 'http://images.amazon.com/images/P/0060973129.01.THUMBZZZ.jpg'),
('0195153448', 'Classical Mythology', 2002, 'Oxford University Press', 'http://images.amazon.com/images/P/0195153448.01.THUMBZZZ.jpg'),
('0374157065', 'Flu: The Story of the Great Influenza Pandemic of 1918 and the Search for the Virus That Caused It', 1999, 'Farrar Straus Giroux', 'http://images.amazon.com/images/P/0374157065.01.THUMBZZZ.jpg'),
('0393045218', 'The Mummies of Urumchi', 1999, 'W. W. Norton &amp', 'http://images.amazon.com/images/P/0393045218.01.THUMBZZZ.jpg'),
('0399135782', 'The Kitchen God\'s Wife', 1991, 'Putnam Pub Group', 'http://images.amazon.com/images/P/0399135782.01.THUMBZZZ.jpg'),
('0425176428', 'What If?: The World\'s Foremost Military Historians Imagine What Might Have Been', 2000, 'Berkley Publishing Group', 'http://images.amazon.com/images/P/0425176428.01.THUMBZZZ.jpg'),
('0671870432', 'PLEADING GUILTY', 1993, 'Audioworks', 'http://images.amazon.com/images/P/0671870432.01.THUMBZZZ.jpg'),
('0679425608', 'Under the Black Flag: The Romance and the Reality of Life Among the Pirates', 1996, 'Random House', 'http://images.amazon.com/images/P/0679425608.01.THUMBZZZ.jpg');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`ISBN`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
