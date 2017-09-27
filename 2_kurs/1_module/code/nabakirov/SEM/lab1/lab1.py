
types = dict(i=int, r=float)


def init_array(length, arr_type):
	array = []
	for i in range(length):
		element = None
		while type(element) is not arr_type:
			element = input('input {} element: '.format(i + 1))

			try:
				element = arr_type(element)
				array.append(element)
			except:
				print('invalid type of inputed element')
			

	return array

def find_max(arr):
	max_el = arr[0]
	max_in = []

	for i, el in enumerate(arr):
		if el > max_el:
			max_el = el
			max_in = [i]
		elif el == max_el:
			max_in.append(i)

	return (max_el, max_in)

def find_min(arr):
	min_el = arr[0]
	min_in = []

	for i, el in enumerate(arr):
		if el < min_el:
			min_el = el
			min_in = [i]
		elif el == min_el:
			min_in.append(i)

	return (min_el, min_in)

def print_arr(arr, max_el, max_in, min_in, min_el):
	print('\n\ninputed array: ', arr)
	print('max element:\t{}'.format(max_el))
	if len(max_in) == 1:
		print('max element index:\t{}'.format(max_in[0]))
	else:
		print('indexes of max elements:\t{}'.format(max_in))

	print('min element:\t{}'.format(min_el))
	if len(min_in) == 1:
		print('min element index:\t{}'.format(min_in[0]))
	else:
		print('indexes of min elements:\t{}'.format(min_in))

def main():
	lenght = None
	while type(lenght) != int:
		lenght = input('input length of the array\n')
		try:
			lenght = int(lenght)
		except:
			print('\ninvalid input, only integers')
	arr_type = None
	while True:
		arr_type = input('input type of the array\n\ti - integer\n\tr - real\n')
		if arr_type == 'i' or arr_type == 'r':
			break
		else:
			print('\ninvalid input, allowed only -i -r')	

	arr = init_array(lenght, types[arr_type])
	max_el, max_in = find_max(arr)
	min_el, min_in = find_min(arr)

	print_arr(arr, max_el, max_in, min_in, min_el)
		
	






if __name__ == '__main__':
	main()