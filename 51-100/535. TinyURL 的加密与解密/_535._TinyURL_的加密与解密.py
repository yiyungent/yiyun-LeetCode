import random

class Codec:
    """
    URL简化类: 将一个长url 转化为 一个短url（转化后的 URL路径 为6位数的字母或数字）

    转化算法：使用 62位 由大小写字母和数字构成的字符串集合 作为 【62进制位表】
        可表示的 6位 url 数量为 62 ** 6 = 586亿多，几亿次以内的调用不用担心
        字典键冲突，不够用的话可以再增加进制位数。
    """

    _chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"

    _dist = {}
    _key = ''.join(random.sample(_chars, 6))

    @classmethod
    def get_rand(self):
        return ''.join(random.sample(self._chars, 6))

    @classmethod
    def encode(self, longUrl: str) -> str:
        """Encodes a URL to a shortened URL.
        将一个 长URL 编码为一个 短URL【随机固定长度加密】

        使用 random 模块 随机从 62位 字符串中选取 6 个作为 URL短路径。
        因为使用了随机数，根据 short_url 来预测字典大小几乎不可能，数据更加安全
        """
        while self._dist.get(self._key):
            self._key = self.get_rand()

        self._dist[self._key] = longUrl

        return 'http://tinyurl.com/' + self._key
 
    @classmethod
    def decode(self, shortUrl: str) -> str:
        """Decodes a shortened URL to its original URL.
        将一个 短URL 解码为一个 长URL

        直接根据 url字符串后 6位，从字典中取值
        """
        return self._dist[shortUrl[19:]]

        

if __name__ == "__main__":
    # https://leetcode-cn.com/problems/encode-and-decode-tinyurl/

    # Your Codec object will be instantiated and called as such:
    codec = Codec()
    print(codec.decode(codec.encode("https://leetcode.com/problems/design-tinyurl")))