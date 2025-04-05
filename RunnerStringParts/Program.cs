using SunamoStringGetLines;
using SunamoStringParts;
using SunamoStringParts.Tests;

namespace RunnerStringParts;

internal class Program
{
    static void Main(string[] args)
    {
        //o();

        SHPartsTests t = new();
        t.KeepAfterFirstTest();
        t.RemoveAfterFirstTest();
    }

    private static void o()
    {
        var input = @"50. ""Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning."" - Rick Cook

49. ""Lisp isn't a language, it's a building material."" - Alan Kay.

48. ""Walking on water and developing software from a specification are easy if both are frozen."" - Edward V Berard

47. ""They don't make bugs like Bunny anymore."" - Olav Mjelde.

46. ""A programming language is low level when its programs require attention to the irrelevant."" - Alan J. Perlis.

45. ""A C program is like a fast dance on a newly waxed dance floor by people carrying razors."" - Waldi Ravens.

44. ""I have always wished for my computer to be as easy to use as my telephone; my wish has come true because I can no longer figure out how to use my telephone."" - Bjarne Stroustrup

43. “Computer science education cannot make anybody an expert programmer any more than studying brushes and pigment can make somebody an expert painter.” - Eric S. Raymond

42. “Don’t worry if it doesn’t work right. If everything did, you’d be out of a job.” - Mosher’s Law of Software Engineering

41. “I think Microsoft named .Net so it wouldn’t show up in a Unix directory listing.” - Oktal

40. “Fine, Java MIGHT be a good example of what a programming language should be like. But Java applications are good examples of what applications SHOULDN’T be like.” - pixadel

39. “Considering the current sad state of our computer programs, software development is clearly still a black art, and cannot yet be called an engineering discipline.” - Bill Clinton

38. ""The use of COBOL cripples the mind; its teaching should therefore be regarded as a criminal offense."" - E.W. Dijkstra

37. ""In the one and only true way. The object-oriented version of 'Spaghetti code' is, of course, 'Lasagna code'. (Too many layers)."" - Roberto Waltman.

36. ""FORTRAN is not a flower but a weed — it is hardy, occasionally blooms, and grows in every computer."" - Alan J. Perlis.

35. “For a long time it puzzled me how something so expensive, so leading edge, could be so useless. And then it occurred to me that a computer is a stupid machine with the ability to do incredibly smart things, while computer programmers are smart people with the ability to do incredibly stupid things. They are, in short, a perfect match.” - Bill Bryson

34. ""In My Egotistical Opinion, most people's C programs should be indented six feet downward and covered with dirt."" - Blair P. Houghton.

33. ""When someone says: 'I want a programming language in which I need only say what I wish done', give him a lollipop."" - Alan J. Perlis

32. ""The evolution of languages: FORTRAN is a non-typed language. C is a weakly typed language. Ada is a strongly typed language. C++ is a strongly hyped language."" - Ron Sercely

31. ""Good design adds value faster than it adds cost."" - Thomas C. Gale

30. ""Python's a drop-in replacement for BASIC in the sense that Optimus Prime is a drop-in replacement for a truck."" - Cory Dodt

29. ""Talk is cheap. Show me the code."" - Linus Torvalds

28. ""Perfection [in design] is achieved, not when there is nothing more to add, but when there is nothing left to take away."" - Antoine de Saint-Exupéry

27. ""C is quirky, flawed, and an enormous success."" - Dennis M. Ritchie.

26. ""In theory, theory and practice are the same. In practice, they’re not."" - Yoggi Berra

25. “You can’t have great software without a great team, and most software teams behave like dysfunctional families.” - Jim McCarthy

24. ""PHP is a minor evil perpetrated and created by incompetent amateurs, whereas Perl is a great and insidious evil, perpetrated by skilled but perverted professionals."" - Jon Ribbens

23. ""Programming is like kicking yourself in the face, sooner or later your nose will bleed."" - Kyle Woodbury

22. ""Perl – The only language that looks the same before and after RSA encryption."" - Keith Bostic

21. ""It is easier to port a shell than a shell script."" - Larry Wall

20. ""I invented the term 'Object-Oriented', and I can tell you I did not have C++ in mind."" - Alan Kay

19. ""Learning to program has no more to do with designing interactive software than learning to touch type has to do with writing poetry"" - Ted Nelson

18. “The best programmers are not marginally better than merely good ones. They are an order-of-magnitude better, measured by whatever standard: conceptual creativity, speed, ingenuity of design, or problem-solving ability.” - Randall E. Stross

17. “If McDonalds were run like a software company, one out of every hundred Big Macs would give you food poisoning, and the response would be, ‘We’re sorry, here’s a coupon for two more.’ “ - Mark Minasi

16. ""Beware of bugs in the above code; I have only proved it correct, not tried it."" - Donald E. Knuth.

15. ""Computer system analysis is like child-rearing; you can do grievous damage, but you cannot ensure success."" - Tom DeMarco

14. ""I don't care if it works on your machine! We are not shipping your machine!"" - Vidiu Platon.

13. ""Sometimes it pays to stay in bed on Monday, rather than spending the rest of the week debugging Monday's code."" - Christopher Thompson- 

12. ""Measuring programming progress by lines of code is like measuring aircraft building progress by weight."" - Bill Gates

11. ""Debugging is twice as hard as writing the code in the first place. Therefore, if you write the code as cleverly as possible, you are, by definition, not smart enough to debug it."" - Brian W. Kernighan.

10. ""People think that computer science is the art of geniuses but the actual reality is the opposite, just many people doing things that build on each other, like a wall of mini stones."" - Donald Knuth

9. “First learn computer science and all the theory. Next develop a programming style. Then forget all that and just hack.” - George Carrette

8. “Most of you are familiar with the virtues of a programmer. There are three, of course: laziness, impatience, and hubris.” - Larry Wall

7. “Most software today is very much like an Egyptian pyramid with millions of bricks piled on top of each other, with no structural integrity, but just done by brute force and thousands of slaves.” - Alan Kay

6. “The trouble with programmers is that you can never tell what a programmer is doing until it’s too late.” - Seymour Cray

5. “To iterate is human, to recurse divine.” - L. Peter Deutsch

4. ""On two occasions I have been asked [by members of Parliament]: 'Pray, Mr. Babbage, if you put into the machine wrong figures, will the right answers come out?' I am not able rightly to apprehend the kind of confusion of ideas that could provoke such a question."" - Charles Babbage

3. ""Most good programmers do programming not because they expect to get paid or get adulation by the public, but because it is fun to program."" - Linus Torvalds

2. ""Always code as if the guy who ends up maintaining your code will be a violent psychopath who knows where you live."" - Martin Golding

1. “There are two ways of constructing a software design. One way is to make it so simple that there are obviously no deficiencies. And the other way is to make it so complicated that there are no obvious deficiencies.” - C.A.R. Hoare";

        var l = SHGetLines.GetLines(input);

        for (int i = l.Count - 1; i >= 0; i--)
        {
            if (string.IsNullOrWhiteSpace(l[i]))
            {
                l.RemoveAt(i);
            }
            else
            {
                l[i] = SHParts.KeepAfterFirst(l[i], ".");
            }
        }

        File.WriteAllLines(@"D:\a.txt", l);
    }
}
