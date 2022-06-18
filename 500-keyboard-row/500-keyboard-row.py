class Solution(object):
    def findWords(self, words):
		row1 = set('QWERTYUIOP')
		row2 = set('ASDFGHJKL')
		row3 = set('ZXCVBNM')

		wordList = []
		
		for word in words:
			string = set(word.upper())
			for charSet in [row1, row2, row3]:
				if string & charSet == string:
					wordList.append(word)
					break

		return wordList