For this take home project I would like for you to implement parsers to parse two different types of csv files.

The two types will be
- Files from DAS Trader PRO (A trading platform)
- Files from ThinkOrSwim (A trading platform)


All files are csvs although not all will be delimited by commas.

Your parsers should be able to:
- Read in the csvs and parse them into POCO's (Models.ChartlogTradeExecution)
- Validate the file before parsing and throw user friendly error messages if the files are bad

Feel free to write your own unit tests as well to test any scenario you can think of that may occur in production

I would like to see some type of "factory" pattern that will be smart enough to read in a file, figure out what type of file it is, and then
use the correct parser to parse it. The logic would look something like this

User uploads file > code base converts stream into text > text is passed to class that detects what type of csv it is 
> factory then creates or selects correct parser > parser validates file > parser throws error or parses file into trades

You are done with the project once your code base passes all included unit tests.

Please create a fork of this project and PR it when finished. Once done, go ahead and email me
and I will take a look.


Happy coding! Looking forward to your solution!
