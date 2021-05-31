from urllib.request import urlopen
import numpy as np
import time

num_obs = 600
values = np.zeros(num_obs)
for i in range(num_obs):
    value = int(urlopen('http://127.0.0.1:8000/hr/get').read().decode())
    values[i] = value
    #print(value)
    time.sleep(1)

print(values)

import scipy.stats as stats

CI = (60*1000)/values
dRR = max(CI)-min(CI)
M = stats.mode(CI).mode
#M = np.median(CI)

import matplotlib.pyplot as plt
n, bins, p = plt.hist(CI, bins=range(int(min(CI)), int(max(CI)), 50), edgecolor='black', label='Распределение кардиоинтервалов')
plt.vlines(M, ymin=0, ymax=max(n), color='r', label='Мода')
plt.legend()

AM = 0
for i in range(len(bins)):
    if bins[i] > M:
        AM = n[i-1]
        break

IN = (AM/num_obs)*100/(2*M/1000*(dRR/1000))
plt.title('Индекс напряженности равен {}'.format(IN))
plt.savefig('INdex.png')
