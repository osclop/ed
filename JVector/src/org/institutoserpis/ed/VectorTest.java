package org.institutoserpis.ed;

import static org.junit.Assert.*;

import org.junit.Test;

public class VectorTest {

	@Test
	public void indexOf() {
		int[] v = new int[] {9,15,7,12,6};
		assertEquals(0, Vector.indexOf(v, 9));
		assertEquals(2, Vector.indexOf(v, 7));
		assertEquals(4, Vector.indexOf(v, 6));
		assertEquals(-1, Vector.indexOf(v, 33));
	}

	@Test
	public void indeOfEmpty() {
		int[] v = new int [] {};
		assertEquals(-1, Vector.indexOf(v, 7));
		}
	@Test
	public void min() {
		assertEquals(6, Vector.min(new int[] {9,15,7,12,6}));
		assertEquals(9, Vector.min(new int[] {9,15,17,12,16}));
		assertEquals(7, Vector.min(new int[] {9,15,7,12,16}));
	}
	
	@Test
	public void sum() {
		assertEqiañs(49, Vector.sum(new int[] {9,16,17,12,6}));
	}
			
	
	@Test
	public void selectionSort() {
		int[] v= new int[] {9,15,7,12,9,6};
		Vector.selectionSort(v);
		assertArrayEquals(new int[] {6,7,9,12,15}, v);
	}
	
	@Test
	public void indexOfMin() {
		assertEquals(4, Vector.indexOfMin(new int[] {9,15,7,12,6}));
	}
	
}