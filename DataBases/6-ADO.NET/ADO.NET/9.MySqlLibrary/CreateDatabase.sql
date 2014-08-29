SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema Library
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `Library` ;
CREATE SCHEMA IF NOT EXISTS `Library` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `Library` ;

-- -----------------------------------------------------
-- Table `Library`.`authors`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Library`.`authors` ;

CREATE TABLE IF NOT EXISTS `Library`.`authors` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Library`.`books`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Library`.`books` ;

CREATE TABLE IF NOT EXISTS `Library`.`books` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `ISBN` VARCHAR(17) NOT NULL,
  `publishDate` DATE NOT NULL,
  `authors_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_books_authors_idx` (`authors_id` ASC),
  CONSTRAINT `fk_books_authors`
    FOREIGN KEY (`authors_id`)
    REFERENCES `Library`.`authors` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
