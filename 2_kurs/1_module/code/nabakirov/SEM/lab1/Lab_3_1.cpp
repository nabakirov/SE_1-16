#include <iostream>

using namespace std;
void arrIN(int *a, int n)
{
    for(int i = 0; i < n; i++)
    {
        cin >> a[i];
    }
}
void arrOUT(int *a, int n)
{
    for(int i = 0; i < n; i++)
    {
        cout << a[i] << "\t";
    }
    cout << endl;
}
void MinMax (int *a, int n, int & min, int & max, float & avArif)
{
    min = a[0];
    max = a[0];
    int k = a[0];
    for(int i = 1; i< n; i++)
    {
        if(min > a[i])
        {
            min = a[i];
        }
        if(max < a[i])
        {
            max = a[i];
        }
        k += a[i];
    }
    avArif = k / float(n);
}
void twoDemArrIn (int **a, int n, int m)
{
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            cin >> a[i][j];
        }
    }
}
void twoDemArrOut (int **a, int n, int m)
{
    cout << endl;
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            cout << a[i][j] << "\t";
        }
        cout << endl;
    }
    cout << endl;
}
void multiplication (int **a, int **b, int **c, int m, int n, int l)
{
    for(int i = 0; i < n; i++)
    {
        for(int k = 0; k < l; k++)
        {
            int C = 0;
            for(int j = 0; j < m; j++)
            {
               
                C += a[i][j] * b[j][k];
                 
            }
          
            c[i][k] = C;
        }
    }
}
void MaxLine(int **a, int n, int m, int & max)
{
    max = 0;
    for(int j = 0; j < m; j++)
    {
        max += a[0][j];
    }
    
    for(int i = 0; i < n; i++)
    {
        int line = 0;
        for(int j = 1; j < m; j++)
        {
            line += a[i][j];
        }
        if(max < line)
        {
            max = line;
        }
    }
}
void MinMaxtwoDemArr(int **a, int n, int m, int &min, int &max, float &sred)
{
    min = a[0][0];
    max = a[0][0];
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            if(min > a[i][j])
            {
                min = a[i][j];
            }
            if(max < a[i][j])
            {
                max = a[i][j];
            }
        }
    }
    sred = (min + max) / float(2);
}
void AbcMaxEl (int **a, int n, int m, int & abmax, int & x, int & y)
{
    abmax = abs(a[0][0]);
    
    for(int i = 0; i < n; i++)
    {   
        for (int j = 0; j < m; j++)
        {
            a[i][j] = abs(a[i][j]);
            if(abmax < a[i][j])
            {
                abmax = a[i][j];
                x = i;
                y = j;
            }
        }
    }
}
void delArr (int **a, int n)
{
    for(int i = 0; i < n; i++)
    {
        delete a[i];
    }
    delete []a;
}
void minEl(int **a, int n, int & min, int & sum)
{
    min = a[0][0];
    int minY;
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
            if(min > a[i][j])
            {
                min = a[i][j];
                minY = i;
            }
        }
    }
    cout << minY;
    for(int i = 0; i < n; i++)
    {
        sum += a[minY][i];
    }
}
void numslowerthanC (int *a, int n, int c, int &cnt)
{
    cnt = 0;
    for(int i = 0; i < n; i++)
    {
        if(a[i] < c)
        {
            cnt++;
        }
    }
}
void SumOfPlusEl(int *a, int n, int &sum)
{
    sum = 0;
    for(int i = 0; i < n; i++)
    {
        if(a[i] > 0)
        {
            sum += a[i];
        }
    }
}
void swapp(int* &a, int n, int m, int b)
{
    for(int i = m; i > 0; i--)
    {
        for(int j = i; j <= b; j++)
        {
            int z = a[j-1];
            a[j-1] = a[j];
            a[j] = z;
        }
    }
}
int main()
{
    int k;
    while (k != 0)
    {
        cout << "Choose a program (0-exit): ";
        cin >> k;
        if (k == 1)
        {
            int n;
            cin >> n;
            int *arr = new int(n);

            int max, min;
            float avArif;
            
            arrIN(arr, n);
            MinMax(arr, n, min, max, avArif);
            
            cout << "\tmax: " << max << endl << "\tmin: " << min << "\n\tArif. avarage: " << avArif<< endl;

            arrOUT(arr, n);
            delete []arr;
        }
        if(k == 2)
        {
            int n ,m;
            cin >> n >> m;
            int **a = new int *[n];
            for(int i = 0; i < n; i++)
            {
                a[i] = new int [m];
            }
            twoDemArrIn(a, n, m);
            int l;
            cin >> l;
            int **b = new int *[m];
            for(int i = 0; i < m; i++)
            {
                b[i] = new int[l];
            }
            twoDemArrIn(b, m, l);
            int **c = new int*[n];
            for(int i = 0; i < n; i++)
            {
                c[i] = new int[l];
            }
            multiplication(a, b, c, m, n, l);

            twoDemArrOut(c, n, l);
            delArr(a, n);
            delArr(b, m);
            delArr(c, n);
        }
        if(k == 3)
        {
            int n, m;
            cin >> n >> m;
            int **a = new int *[n];
            for(int i = 0; i < n; i++)
            {
                a[i] = new int [m];
            }
            twoDemArrIn(a, n, m);
            int max;
            MaxLine(a, n, m, max);
            cout << max << endl;
            delArr(a, n);
        }
        if(k == 4)
        {
            int n, m;
            cin >> n >> m;
            int **a = new int*[n];
            for(int i = 0; i < n; i++)
            {
                a[i] = new int[m];
            }
            twoDemArrIn(a, n, m);
            int min;
            int max;
            float avArif;
            MinMaxtwoDemArr(a, n, m, min, max, avArif);
            cout << min << endl << max << endl << avArif << endl;
            delArr(a, n);

        }
        if(k == 5)
        {
            int n, m;
            cin >> n >> m;
            int **a = new int*[n];
            for(int i = 0; i < n; i++)
            {
                a[i] = new int[m];
            }
            twoDemArrIn(a, n, m);
            int absmax;
            int x;
            int y;
            AbcMaxEl(a, n, m, absmax, x, y);
            cout << absmax << "\n\t" << x <<" " << y << endl;
            delArr(a, n);
        }
        if(k == 6)
        {
            int n, m;
            cin >> n;
            int **a = new int*[n];
            for(int i = 0; i < n; i++)
            {
                a[i] = new int[n];
            }
            twoDemArrIn(a, n, n);
            int min, sum;
            minEl(a, n, min, sum);
            cout << "\t min: " << min << "\n\tsum: " << sum << endl;
        }
        if(k == 7)
        {
            int n;
            int c;
            cin >> n;
            cin >> c;
            int *a = new int[n];
            arrIN(a, n);
            int cnt;
            numslowerthanC(a, n, c, cnt);
            cout << "a: " << cnt << endl;
            int sum;
            SumOfPlusEl(a, n, sum);
            cout << sum << endl;
            int m, b;
            cin >> m >> b;
            swapp(a, n, m, b);
            arrOUT(a, n);
        }




    }
    return 0;
}