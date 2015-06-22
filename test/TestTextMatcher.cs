using System;
using Xunit;

using TextMatch.Services;

namespace test
{
    public class TestTextMatcher
    {
        private string _textstr;

        public TestTextMatcher()
        {
            this._textstr = @"Polly put the kettle on, polly put the kettle on, polly put the kettle on we’ll all have tea";    
        }
        
        [Fact]
        public void TextMatchWithPollyReturn3Pos()
        {
            var tmatch = new TextMatcher();
            var res = tmatch.MatchText(this._textstr,"Polly");
            Assert.Equal(3, res.Length);
        }
        
        [Fact]
        public void TextMatchWith_polly_Return3Pos()
        {
            var tmatch = new TextMatcher();
            var res = tmatch.MatchText(this._textstr,"polly");
            Assert.Equal(3, res.Length);
        }
        
        [Fact]
        public void TextMatchWithPOLLYReturn3Pos()
        {
            var tmatch = new TextMatcher();
            var res = tmatch.MatchText(this._textstr,"POLLY");
            Assert.Equal(3, res.Length);
        }
        
        [Fact]
        public void TextMatchWithPollyReturn0AsFirst()
        {
            var tmatch = new TextMatcher();
            var res = tmatch.MatchText(this._textstr,"Polly");
            Assert.Equal(0, res[0]);
        }
        
        [Fact]
        public void TextMatchWithPollyReturn25AsSnd()
        {
            var tmatch = new TextMatcher();
            var res = tmatch.MatchText(this._textstr,"Polly");
            Assert.Equal(25, res[1]);
        }
        
        [Fact]
        public void TextMatchWithPollyReturn50AsThird()
        {
            var tmatch = new TextMatcher();
            var res = tmatch.MatchText(this._textstr,"Polly");
            Assert.Equal(50, res[2]);
        }
        
        [Fact]
        public void TextMatchWith_ll_Return5Pos()
        {
            var tmatch = new TextMatcher();
            var res = tmatch.MatchText(this._textstr,"ll");
            Assert.Equal(5, res.Length);
        }
        
        [Fact]
        public void TextMatchWith_LL_Return5Pos()
        {
            var tmatch = new TextMatcher();
            var res = tmatch.MatchText(this._textstr,"ll");
            Assert.Equal(5, res.Length);
        }
        
        [Fact]
        public void TextMatchWithXReturn0Pos()
        {
            var tmatch = new TextMatcher();
            var res = tmatch.MatchText(this._textstr,"X");
            Assert.Equal(0, res.Length);
        }
        
        [Fact]
        public void TextMatchWithPolxReturn0Pos()
        {
            var tmatch = new TextMatcher();
            var res = tmatch.MatchText(this._textstr,"Polx  ");
            Assert.Equal(0, res.Length);
        }
        
        [Fact]
        public void TextMatchWithSubstrLongerReturn0Pos()
        {
            var tmatch = new TextMatcher();
            var res = tmatch.MatchText("123","123456");
            Assert.Equal(0, res.Length);
        }
        
        [Fact]
        public void TextMatchWithEmptyMainStrReturn0Pos()
        {
            var tmatch = new TextMatcher();
            var res = tmatch.MatchText(String.Empty,"123456");
            Assert.Equal(0, res.Length);
        }
        
        [Fact]
        public void TextMatchWithNullMainStrReturn0Pos()
        {
            var tmatch = new TextMatcher();
            var res = tmatch.MatchText(null,"123456");
            Assert.Equal(0, res.Length);
        }
        
        [Fact]
        public void TextMatchWithNullSubStrReturn0Pos()
        {
            var tmatch = new TextMatcher();
            var res = tmatch.MatchText(this._textstr, null);
            Assert.Equal(0, res.Length);
        }
    }
}
