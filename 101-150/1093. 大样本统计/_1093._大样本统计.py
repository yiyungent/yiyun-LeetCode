from typing import List

class Solution:

    # 方法1: 双指针
    def sampleStats(self, count: List[int]) -> List[float]:
        min_val, max_val = -1, -1

        total = 0
        total_cnt = 0
        max_cnt  =-1
        common_val = -1
        
        buf = []
        for val, cnt in enumerate(count):
            if cnt != 0:
                buf.append((val, cnt))

                max_val = val
                if min_val == -1:
                    min_val = val

                total += cnt * val
                total_cnt += cnt

                if cnt > max_cnt:
                    common_val = val
                    max_cnt = cnt

        mean_val = total / total_cnt

        target = total_cnt // 2 + (total_cnt & 1)
        even = (total_cnt & 1) == 0

        total_cnt = 0
        mid_val = 0
        for i, (val, cnt) in enumerate(buf):
            if total_cnt + cnt >= target:
                if not even or total_cnt + cnt > target:
                    mid_val = val
                else:
                    mid_val = (val + buf[i+1][0]) / 2

                break

            total_cnt += cnt

        return [float(x) for x in [min_val, max_val, mean_val, mid_val, common_val]]




if __name__ == "__main__":
    
    # https://leetcode-cn.com/problems/statistics-from-a-large-sample/

    count = [0,1,3,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0]
    print(Solution().sampleStats(count))

